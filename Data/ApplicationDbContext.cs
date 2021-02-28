
using System;
using MySql.Data.MySqlClient;

namespace aspbiblio.Data
{
    public class MySqlDatabase : IDisposable
    {
        //Declaration d'une variable Connection de type MySqlConnection
        public MySqlConnection Connection;

        public MySqlDatabase(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
            this.Connection.Open();
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}