using Proje.Data;
using Proje.Data.Repositories.Interfaces;
using Proje.web.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Data.Repositories
{
    public class ReservationSaveRepository : Repository<Reservations>, IReservationSaveRepository
    {
        public ReservationSaveRepository(ProjeDbContext context) : base(context)
        {
        }
    }
}
