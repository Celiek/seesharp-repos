using System;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Members m = new Members();

            string haslo;
            string login;
            Console.WriteLine("Podaj login: ");
            login = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Podaj hasło :");
            haslo = Convert.ToString(Console.ReadLine());

            Console.WriteLine(m.IsCorrect(login, haslo));

            string MyConnection = "server=127.0.0.1;uid=root;" + "pwd=;database=project_szkola";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = MyConnectionString;
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            m.IsCorrect(login, haslo);

        }
    }
}
