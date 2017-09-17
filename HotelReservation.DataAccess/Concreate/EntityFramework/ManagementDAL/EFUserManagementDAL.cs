using HotelReservation.Core.DataAccess.EntityFramework;
using HotelReservation.DataAccess.Abstract;
using HotelReservation.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.DataAccess.Concreate.EntityFramework.ManagementDAL
{
    public class EFUserManagementDAL : EFEntityRepositoryBase<HotelReservationDBContext, Users>, IUserManagementDAL
    {
    }
}
