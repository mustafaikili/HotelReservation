using HotelReservation.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Core.DataAccess.EntityFramework
{
    public class EFEntityRepositoryBase<TContext, TEntity> : IEntityRepository<TEntity>
        where TEntity : class,IEntity, new() //Class türünde olsun fakat bu class'lar IEntity'i misas alsın ve new edilmemiş olsun
        where TContext : DbContext, new()
    {
        TContext context = NewContext<TContext>.Context; // IOC kullandığımız zaman buna gerek kalmayacak şuanda Dependency 
                                                        //  prensibini BLL ne DAL new ettiğimiz için ihlal ediyoruz 
        public void Add(TEntity entity)
        {
                var addEntity = context.Entry(entity);
                addEntity.State = EntityState.Added;
                context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
                var deleteEntity = context.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
                var updateEntity = context.Entry(entity);
                updateEntity.State = EntityState.Modified;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
                var getEntity = context.Set<TEntity>().Where(filter).FirstOrDefault();
                return getEntity;
        }

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }
    }
}
