using System;

namespace InEx4
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectioString)
            : base(connectioString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Sql connection is open");
        }

        public override void Close()
        {
            Console.WriteLine("Sql connection is close");
        }

    }
}
