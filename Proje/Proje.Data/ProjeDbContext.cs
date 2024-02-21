using Microsoft.EntityFrameworkCore;
using Proje.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Proje.web.Models;

namespace Proje.Data
{
    public class ProjeDbContext : DbContext
    {
        public ProjeDbContext(DbContextOptions<ProjeDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get;set; }
        public DbSet<Reservations> Reservations { get; set; }

    }
}
