using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Scheduling
{
    class Appointment
    {
        //method to add appointment
        public Boolean addAppointment(AppointmentInfo customerInfo)
        {
            string query = "INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                                "VALUES (@customerId, @userId, @title, @description, @location, @contact, @type, @url, @start, @end, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);

                cmd.Parameters.Add(new MySqlParameter("@customerId", customerInfo.CustomerId));
                cmd.Parameters.Add(new MySqlParameter("@userId", Convert.ToInt32(GlobalMembers.userData.getCurrentUserID())));
                cmd.Parameters.Add(new MySqlParameter("@title", customerInfo.Title));
                cmd.Parameters.Add(new MySqlParameter("@description", customerInfo.Description));
                cmd.Parameters.Add(new MySqlParameter("@location", customerInfo.Location));
                cmd.Parameters.Add(new MySqlParameter("@contact", customerInfo.Contact));
                cmd.Parameters.Add(new MySqlParameter("@type", customerInfo.Type));
                cmd.Parameters.Add(new MySqlParameter("@url", customerInfo.Url));
                cmd.Parameters.Add(new MySqlParameter("@start", customerInfo.StartDate));
                cmd.Parameters.Add(new MySqlParameter("@end", customerInfo.EndDate));
                cmd.Parameters.Add(new MySqlParameter("@createDate", DateTime.Now.ToString("yyyyMMddHHmmss")));
                cmd.Parameters.Add(new MySqlParameter("@createdBy", GlobalMembers.userData.getCurrentUser()));
                cmd.Parameters.Add(new MySqlParameter("@lastUpdate", DateTime.Now.ToString("yyyyMMddHHmmss")));
                cmd.Parameters.Add(new MySqlParameter("@lastUpdateBy", GlobalMembers.userData.getCurrentUser()));

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Close();
                cmd.Dispose();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        //Get customer infoirmation to pre-fill input boxes on modify appointment
        public AppointmentInfo getAppointment(int selectedAppointment)
        {
            string query = "SELECT customerId, title, description, location, contact, type, url, start, end " +
                            "FROM appointment " +
                            "WHERE appointmentId ='" + selectedAppointment + "'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    GlobalMembers.appointmentInfo.CustomerId = Convert.ToInt32(reader["customerId"]);
                    GlobalMembers.appointmentInfo.Title = reader["title"].ToString();
                    GlobalMembers.appointmentInfo.Description = reader["description"].ToString();
                    GlobalMembers.appointmentInfo.Location = reader["location"].ToString();
                    GlobalMembers.appointmentInfo.Contact = reader["Contact"].ToString();
                    GlobalMembers.appointmentInfo.Type = reader["type"].ToString();
                    GlobalMembers.appointmentInfo.Url = reader["url"].ToString();
                    GlobalMembers.appointmentInfo.StartDate = reader["start"].ToString();
                    GlobalMembers.appointmentInfo.EndDate = reader["end"].ToString();
                }

                reader.Close();
                cmd.Dispose();
                return GlobalMembers.appointmentInfo;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        //make changes to appointment
        public Boolean updateAppointment(AppointmentInfo customerInfo, int appointmentId)
        {
            string query = "UPDATE appointment " +
                "SET customerId=@customerId, title=@title, description=@description, location=@location, contact=@contact, type=@type, url=@url,start =@start, end=@end, createDate=@createDate, createdBy=@createdBy, lastUpdate=@lastUpdate, lastUpdateBy=@lastUpdateBy " +
                "WHERE appointmentId='" + appointmentId + "'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);

                cmd.Parameters.Add(new MySqlParameter("@customerId", customerInfo.CustomerId));
                cmd.Parameters.Add(new MySqlParameter("@title", customerInfo.Title));
                cmd.Parameters.Add(new MySqlParameter("@description", customerInfo.Description));
                cmd.Parameters.Add(new MySqlParameter("@location", customerInfo.Location));
                cmd.Parameters.Add(new MySqlParameter("@contact", customerInfo.Contact));
                cmd.Parameters.Add(new MySqlParameter("@type", customerInfo.Type));
                cmd.Parameters.Add(new MySqlParameter("@url", customerInfo.Url));
                cmd.Parameters.Add(new MySqlParameter("@start", customerInfo.StartDate));
                cmd.Parameters.Add(new MySqlParameter("@end", customerInfo.EndDate));
                cmd.Parameters.Add(new MySqlParameter("@createDate", DateTime.Now.ToString("yyyyMMddHHmmss")));
                cmd.Parameters.Add(new MySqlParameter("@createdBy", GlobalMembers.userData.getCurrentUser()));
                cmd.Parameters.Add(new MySqlParameter("@lastUpdate", DateTime.Now.ToString("yyyyMMddHHmmss")));
                cmd.Parameters.Add(new MySqlParameter("@lastUpdateBy", GlobalMembers.userData.getCurrentUser()));

                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();
                cmd.Dispose();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        //delete appointment
        public Boolean deleteAppointment(int appointmentId)
        {
            string query = "DELETE FROM appointment " +
                            "WHERE appointmentId ='" + appointmentId + "'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();

                reader.Close();
                cmd.Dispose();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

    }
}
