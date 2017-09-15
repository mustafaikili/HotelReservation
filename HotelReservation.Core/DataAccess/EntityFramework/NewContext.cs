using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Core.DataAccess.EntityFramework
{
    public static class NewContext<TContext> where TContext : DbContext,new()
    {
        private static TContext context;
        public static TContext Context
        {
            get
            {
                if (context == null)
                    context= new TContext();
                return Context;
            }
        }
    }
}
