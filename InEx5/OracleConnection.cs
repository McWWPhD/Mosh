using System;

namespace InEx5
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string OracleConnectionString)
            :base(OracleConnectionString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Oracle connection is Open");
        }


        public override void Close()
        {
            Console.WriteLine("Oracle connection is Closed");
        }

    }
}
