using System.Data;

namespace DDDApplication.Infrastructure
{
    public interface IDatabase
    {
        void ExecuteNonQuery(string sql);
        IDataReader ExecuteQuery(string sql);
    }
}
