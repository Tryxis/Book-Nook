using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Book_Nook.DataAccess.Interfaces;

namespace Book_Nook.DataAccess.Repositories
{
    public class GenRepository<T> : IGenRepository<T> where T : class
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}