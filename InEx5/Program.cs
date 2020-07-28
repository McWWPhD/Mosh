using System;
using System.ComponentModel.DataAnnotations;

namespace InEx5
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "DB command";
            string connectionString = @"123.32.32.4\Folder\DB\";

            var oracleConnection = new OracleConnection(connectionString);
            var sqlConnection = new SQLConnection(connectionString);

            //var dbCommand = new DbCommand(command, oracleConnection);
            var dbCommand = new DbCommand(command, sqlConnection);


            dbCommand.Execute(command);



        }
    }
}
