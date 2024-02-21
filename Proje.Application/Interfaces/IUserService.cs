using Proje.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proje.Application.Interfaces
{
    public interface IUserService
    {
      
        IEnumerable<User> GetAll();
        User Get(int? id);
        void Add(User user);
        void ChangeStatus(int? id);
        void Edit(User user);
        void Remove(User user);

    }
}
