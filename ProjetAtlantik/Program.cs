using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ProjetAtlantik
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = "server=localhost;database=Atlantik;user=root;password=;";
            MySqlConnection maCnx = new MySqlConnection(connectionString);

            Application.Run(new FormPlaceDispo(maCnx));
        }
    }
}
