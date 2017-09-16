using HotelReservation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model.Mapping.EntityFramework
{
    public class PaymentsMap: EntityTypeConfiguration<Payments>
    {
        public PaymentsMap()
        {
            //Primary KEY
            HasKey(x => x.PaymentID);

            //Property
            Property(x => x.TotalPrice).HasColumnType("money").IsRequired();
            Property(x => x.Description).HasMaxLength(500).IsOptional();

            Property(x => x.CreatedBy).IsOptional();
            Property(x => x.CreatedDate).HasColumnType("datetime2").HasPrecision(0).IsOptional();
            Property(x => x.LastModifiedBy).IsOptional();
            Property(x => x.LastModifiedDate).HasColumnType("datetime2").HasPrecision(0).IsOptional();
            Property(x => x.IsActive).IsOptional();

            //Foreign KEY
            HasRequired(x => x.Reservation).WithMany(x => x.Payment).HasForeignKey(x=>x.ReservationID).WillCascadeOnDelete(true);
            HasRequired(x => x.PaymentType).WithMany(x => x.Payment).HasForeignKey(x => x.PaymentTypeID).WillCascadeOnDelete(true);
        }
    }
}
