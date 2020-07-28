using System;

namespace InEx5
{
    public class SQLConnection : DbConnection
    {
        public SQLConnection(string SQLconnectionString)
            : base(SQLconnectionString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("SQL connection is Open");
        }


        public override void Close()
        {
            Console.WriteLine("SQL connection is Closed");
        }
    }
}
