using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDDApplication.Infrastructure
{
    public interface IRepository<T>
    {
        T Get(Guid id);
        IEnumerable<T> EnumerateAll();
        void UpdateOrCreate(Guid id, T entity);
        void Delete(Guid id);
    }
}
