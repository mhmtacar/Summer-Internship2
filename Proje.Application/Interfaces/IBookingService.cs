using Proje.web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Application.Interfaces
{
    public interface IBookingService
    {
        IEnumerable<Reservations> GetAll();
    }
}
