using System;

namespace InEx5
{
    public class DbConnection
    {
        private readonly string _connectionString;

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString) )
                throw new Exception("Connection string cannot be null or empty");

            _connectionString = connectionString;

        }

        public virtual void Open()
        { }

        public virtual void Close() 
        { }

    }
}
