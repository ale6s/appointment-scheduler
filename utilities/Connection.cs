using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace Scheduling
{
    public class Connection
    {
        public static MySqlConnection conn { get; set; }

        public static void startConnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

            try
            {
                conn = new MySqlConnection(constr);

                //open connection
                conn.Open();
                Console.WriteLine("connection is open");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void stopConnection()
        {
            try
            {
                if (conn != null)
                {
                    conn.Close();
                }
                conn = null;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}