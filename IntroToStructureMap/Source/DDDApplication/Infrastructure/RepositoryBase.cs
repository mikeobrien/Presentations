using System;
using System.Collections.Generic;
using System.Linq;

namespace DDDApplication.Infrastructure
{
    public class RepositoryBase<T>
    {
        private IDatabase _database;

        public RepositoryBase(IDatabase database)
        {
            _database = database;
        }

        public T Get(Guid id)
        {
            _database.ExecuteQuery(string.Format("SELECT TOP 1 * FROM {0} WHERE Id='{1}'", typeof(T).Name, id));
            return default(T);
        }

        public IEnumerable<T> EnumerateAll()
        {
            _database.ExecuteQuery(string.Format("SELECT * FROM {0}", typeof(T).Name));
            return Enumerable.Empty<T>();
        }

        public void UpdateOrCreate(Guid id, T entity)
        {
            _database.ExecuteQuery(string.Format("UPDATE_SELECT * FROM {0} WHERE Id='{1}'", typeof(T).Name, id));
        }

        public void Delete(Guid id)
        {
            _database.ExecuteQuery(string.Format("DELETE * FROM {0} WHERE Id='{1}'", typeof(T).Name, id));
        }
    }
}
