using Microsoft.VisualBasic;
using System;

namespace InEx4
{

    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "conection";

            var sqlConnection = new SqlConnection(connectionString);
            var oracleConnection = new OracleConnection(connectionString);

            sqlConnection.Open();
            sqlConnection.Close();

            oracleConnection.Open();
            oracleConnection.Close();
        }
    }
}
