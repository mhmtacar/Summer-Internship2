using Proje.web.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Interfaces
{
    public interface IReservationDetailService
    {
        Task<Reservations> SaveReservation(string reservationNumber,string token);
    }
}
