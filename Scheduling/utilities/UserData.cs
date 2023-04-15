using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Scheduling.utilities
{
    class UserData
    {
        //Will get Name session from the file. this method is called after loging in. will get the last input value from loginIngo.txt
        public string getCurrentUser()
        {
            String currentUserID = File.ReadLines(@"..\..\loginInfo.txt").Last();

            Console.WriteLine("current user id: " + currentUserID);

            string query = "SELECT userName, userId FROM user WHERE userId = '" + currentUserID + "'";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string userId = reader["userId"].ToString();
                    string userName = reader["userName"].ToString();
                    reader.Close();
                    cmd.Dispose();
                    return userName;
                }
                else
                    MessageBox.Show("Unable to get Last ID, please check connection to DB", "Database Error Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }


        //Will get userID session from the file. this method is called after loging in. will get the last input value from loginIngo.txt
        public string getCurrentUserID()
        {
            String currentUserID = File.ReadLines(@"..\..\loginInfo.txt").Last();

            Console.WriteLine("current user id: " + currentUserID);

            string query = "SELECT userName, userId FROM user WHERE userId = '" + currentUserID + "'";


            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string userId = reader["userId"].ToString();
                    string userName = reader["userName"].ToString();
                    reader.Close();
                    cmd.Dispose();
                    return userId;
                }
                else
                    MessageBox.Show("Unable to get Last ID, please check connection to DB", "Database Error Customer ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }


        //Get customer name only and ID for combox when adding an appointment
        public List<string> getAllCustomerId()
        {
            List<string> list = new List<string>();

            string query = "SELECT customerId, customerName FROM customer";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string dbName = reader["customerName"].ToString();
                    string dbcusomerId = reader["customerId"].ToString();

                    list.Add(dbcusomerId);

                }

                reader.Close();
                cmd.Dispose();
                return list;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        //only to display the correct customer name
        public string getAllCustomerName(int customerId)
        {

            string query = "SELECT customerName FROM customer WHERE customerId='" + customerId + "'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string customerName = reader["customerName"].ToString();

                    reader.Close();
                    cmd.Dispose();
                    return customerName;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            return null;
        }

        //get user start date for comparision when adding an appointment
        public List<string> getUserStartDate(string customerId)
        {
            List<string> list = new List<string>();

            string query = "SELECT start FROM appointment WHERE customerId='" + customerId + "'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string dbStart = reader["start"].ToString();

                    list.Add(dbStart);
                }

                reader.Close();
                cmd.Dispose();
                return list;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        //user end date for comparision when adding an appointment
        public List<string> getUserEndDate(string customerId)
        {
            List<string> list = new List<string>();

            string query = "SELECT end FROM appointment WHERE customerId='" + customerId + "'";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string dbEnd = reader["end"].ToString();

                    list.Add(dbEnd);
                }

                reader.Close();
                cmd.Dispose();
                return list;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}