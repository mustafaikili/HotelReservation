using HotelReservation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model.Mapping.EntityFramework
{
    public class RoomImagesMap : EntityTypeConfiguration<RoomImages>
    {
        public RoomImagesMap()
        {
            //Primary KEY
            HasKey(x => x.RoomImageID);

            //Property
            Property(x => x.Destination).IsRequired();

            Property(x => x.CreatedBy).IsOptional();
            Property(x => x.CreatedDate).HasColumnType("datetime2").HasPrecision(0).IsOptional();
            Property(x => x.LastModifiedBy).IsOptional();
            Property(x => x.LastModifiedDate).HasColumnType("datetime2").HasPrecision(0).IsOptional();
            Property(x => x.IsActive).IsOptional();

            //Foreign KEY
            HasRequired(x => x.Room).WithMany(x => x.RoomImage).HasForeignKey(x=>x.RoomNumber).WillCascadeOnDelete(true);
        }
    }
}
