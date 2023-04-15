using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Scheduling
{
    class Reports
    {

        //will only display records from dates bigger or equal than today Main screen Get appointment report
        public MySqlDataReader getUpcomingAppointment()
        {
            string currenTime = DateTime.Now.ToString("yyyy-MM-dd");

            string query = "SELECT * FROM appointment WHERE start >= '" + currenTime + "'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        //show only appointments with in 15mins before they start
        public MySqlDataReader getAppointmentNotification()
        {
            string currenTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "SELECT * FROM appointment WHERE start BETWEEN '" + currenTime + "' AND DATE_ADD('" + currenTime + "', INTERVAL 15 MINUTE) AND createdBy='" + GlobalMembers.userData.getCurrentUser() + "'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();

                return reader;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        //will check if there is an appointment with in 15mins
        public Boolean checkAppointmentNotification()
        {
            string currenTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            string query = "SELECT start FROM appointment WHERE start BETWEEN '" + currenTime + "' AND DATE_ADD('" + currenTime + "', INTERVAL 15 MINUTE) AND createdBy='" + GlobalMembers.userData.getCurrentUser() + "'";

            MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    reader.Close();
                    cmd.Dispose();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                cmd.Dispose();
            }
            return false;
        }


        //Get users on main screen  Get USers report
        public MySqlDataReader getAllCustomers()
        {
            string query = "SELECT customer.customerId, customer.customerName, customer.active, address.address, address.address2, address.postalCode, address.phone, city.city, country.country, country.createDate, country.createdBy, country.lastUpdate, country.lastUpdateBy " +
                "FROM customer " +
                "INNER JOIN address on address.cityId = customer.addressId " +
                "INNER JOIN city on city.countryId = address.cityId " +
                "INNER JOIN country on country.countryId = city.countryId";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();

                return reader;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        /*
         * Reports for control buttons - first control button report - View Appointment BTN
         * */

        //get all History appoitments  Get appointment report
        public MySqlDataReader getAllAppointment()
        {
            string query = "SELECT * FROM appointment";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        //get weekly appoitments  Get appointment report
        public MySqlDataReader getWeeklyAppointment()
        {
            string query = "SELECT * FROM appointment WHERE start >= DATE_SUB(NOW(), INTERVAL 1 WEEK)";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        //get motly appoitments Get appointment report
        public MySqlDataReader getMontlyAppointment()
        {
            string query = "SELECT * FROM appointment WHERE start >= DATE_SUB(NOW(), INTERVAL 1 MONTH)";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();
                return reader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        /*
 * Reports for control buttons - second control button report - View Appointment BTN
 * */
        //get appointment report 
        public MySqlDataReader getTypeOfAppointment(string month)
        {
            string query = "SELECT concat(type,' Count: ', COUNT(type)) FROM appointment WHERE MONTHNAME(start)='" + month + "' GROUP BY type";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }
        /*
        * Reports for control buttons - Third control button report - consultAppointmentReportForm
        * */

        public MySqlDataReader getAppointmnetsByUser(string userId)
        {
            string query = "SELECT * FROM appointment " +
                "WHERE customerId='" + userId + "'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        /*
        * Reports for control buttons - second control button report - view count report by user
        * */
        //get appointment report 
        public MySqlDataReader getMontlyCountReportByUser(string month)
        {
            string query = "SELECT concat(customer.customerName,' Count: ', COUNT(appointment.customerId)) " +
                "FROM appointment " +
                "INNER JOIN customer on appointment.customerId = customer.customerId " +
                "WHERE MONTHNAME(start)='" + month + "' " +
                "GROUP BY customer.customerName";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();

                return reader;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

    }
}
