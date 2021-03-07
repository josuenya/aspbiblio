using System;
using MySql.Data.MySqlClient;

namespace aspbiblio.Data
{
    public class ApplicationDbContext : IDisposable
    {
        //Declaration d'une variable Connection de type MySqlConnection
        public MySqlConnection Connection;

        public ApplicationDbContext(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
            this.Connection.Open();
        }

        //close connection
        public void Dispose()
        {
            Connection.Close();
        }
    }
}