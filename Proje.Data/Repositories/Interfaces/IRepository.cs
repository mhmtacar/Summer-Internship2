using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Proje.Data.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        //Repository Generic Interface for all repository patterns
        T Get(int? id);
        IEnumerable<T> GetAll();
        T Find(int id);

        void Add(T entity);
        void AddRange(IEnumerable<T> entities);

        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

        void Update(T entity);
        void Save(T entity);
    }
}
