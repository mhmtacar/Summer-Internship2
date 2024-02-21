using Proje.Data;
using Proje.Data.Repositories;
using Proje.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proje.Data
{
    public interface IUnitOfWork
    {
        public IUserRepository User { get; }
        public IReservationSaveRepository ReservationSave { get; }
        void Complete();
        void Dispose();
    }
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjeDbContext _context;

        public IUserRepository User { get; private set; }
        public IReservationSaveRepository ReservationSave { get; private set; }



        public UnitOfWork(ProjeDbContext context)
        {
            _context = context;

            User = new UserRepository(context);
            ReservationSave = new ReservationSaveRepository(context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
    
