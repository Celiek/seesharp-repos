using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient.MySqlConnection conn;

namespace Members
{
    class Połączenie
    {
        public string IsConnnected(string login , string  haslo )
        {
            string MyConnection = "server=127.0.0.1;uid=root;" + "pwd=;database=project_szkola";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = MyConnectionString;
                conn.Open();
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
