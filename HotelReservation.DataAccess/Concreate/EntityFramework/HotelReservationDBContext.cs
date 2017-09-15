using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.DataAccess.Concreate.EntityFramework
{
    public class HotelReservationDBContext : DbContext
    {
        public HotelReservationDBContext():base ("Server=.;Database=MiHotelReservation;Integrated Security=True;")
        {
            Database.SetInitializer<HotelReservationDBContext>(new DropCreateDatabaseIfModelChanges<HotelReservationDBContext>());
        }
    }
}
