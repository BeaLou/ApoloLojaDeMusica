using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoAUsarPanelHihi.DB.Base
{
    class Connection 
    {
        public MySqlConnection Create()
        {
            string connectionString = "server=localhost;database=ApoloDB;uid=root;password=1234;sslmode=none";

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            return connection;
        }

    }
}
