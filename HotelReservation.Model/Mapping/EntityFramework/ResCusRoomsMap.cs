using HotelReservation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.Model.Mapping.EntityFramework
{
    public class ResCusRoomsMap: EntityTypeConfiguration<ResCusRooms>
    {
        public ResCusRoomsMap()
        {
            //Primary KEY
            HasKey(x => new { x.CustomerID,x.ReservationID,x.RoomNumber});

            //Foreign KEY
            HasRequired(x => x.Customer).WithMany(x => x.ResCusRoom).HasForeignKey(x => x.CustomerID).WillCascadeOnDelete(true);
            HasRequired(x => x.Room).WithMany(x => x.ResCusRoom).HasForeignKey(x => x.RoomNumber).WillCascadeOnDelete(true);
            HasRequired(x => x.Reservation).WithMany(x => x.ResCusRoom).HasForeignKey(x => x.ReservationID).WillCascadeOnDelete(true);
        }
    }
}
