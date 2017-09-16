using HotelReservation.Model.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model.Mapping.EntityFramework
{
    public class ReservationTypesMap : EntityTypeConfiguration<ReservationTypes>
    {
        public ReservationTypesMap()
        {
            //Primary KEY
            HasKey(x => x.ReservationTypeID);

            //Property
            Property(x => x.ReservationTypeName).HasColumnType("nvarchar").HasMaxLength(50).HasColumnAnnotation(IndexAnnotation.AnnotationName, 
                new IndexAnnotation(new IndexAttribute("ReservatonTypeName_Unique") { IsUnique = true })).IsRequired();
            Property(x => x.ServicePrice).HasColumnType("money").IsRequired();
            Property(x => x.Description).HasMaxLength(500).IsOptional();

            Property(x => x.CreatedBy).IsOptional();
            Property(x => x.CreatedDate).HasColumnType("datetime2").HasPrecision(0).IsOptional();
            Property(x => x.LastModifiedBy).IsOptional();
            Property(x => x.LastModifiedDate).HasColumnType("datetime2").HasPrecision(0).IsOptional();
            Property(x => x.IsActive).IsOptional();


        }
    }
}
