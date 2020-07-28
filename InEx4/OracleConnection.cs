using System;

namespace InEx4
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Oracle connection is open");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection is close");
        }

    }
}
