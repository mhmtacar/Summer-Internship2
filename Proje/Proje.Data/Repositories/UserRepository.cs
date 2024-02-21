using Proje.Data;
using Proje.Data.Repositories.Interfaces;
using Proje.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proje.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(ProjeDbContext context) : base(context)
        {

        }

    }
} 
