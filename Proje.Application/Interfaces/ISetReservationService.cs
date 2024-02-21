using Proje.web.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Proje.Application.Interfaces
{
    public interface ISetReservationService
    {
        Task<Reservation> SetReservation(string FistName, string LastName, string Email , string transactionId,string token);
    }
}
