using System;

namespace DDDApplication.Infrastructure
{
    public class SqlDatabase : IDatabase
    {
        public void ExecuteNonQuery(string sql)
        {
            Console.WriteLine(sql);
        }

        public System.Data.IDataReader ExecuteQuery(string sql)
        {
            Console.WriteLine(sql);
            return null;
        }
    }
}
