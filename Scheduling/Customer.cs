using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Scheduling
{
    class Customer
    {

        public Boolean addCountry(CustomerInfo customerInfo)
        {
            string query = "INSERT INTO country(country, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                                "VALUES (@country, @createDate, @createdBy, @lastUpdate, @lastUpdateBy)";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);

                cmd.Parameters.Add(new MySqlParameter("@country", customerInfo.Country));
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

        public Boolean addCity(CustomerInfo customerInfo)
        {
            string query = "INSERT INTO city(city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                                "SELECT @city, countryId, @createDate, @createdBy, @lastUpdate, @lastUpdateBy FROM country ORDER BY countryId DESC LIMIT 1";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);

                cmd.Parameters.Add(new MySqlParameter("@city", customerInfo.City));
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


        public Boolean addAddress(CustomerInfo customerInfo)
        {

            string query = "INSERT INTO address(address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                                "SELECT @address, @address2, cityId, @postalCode, @phone, @createDate, @createdBy, @lastUpdate, @lastUpdateBy " +
                                "FROM city ORDER BY cityId DESC LIMIT 1";
            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);

                cmd.Parameters.Add(new MySqlParameter("@address", customerInfo.Address));
                cmd.Parameters.Add(new MySqlParameter("@address2", customerInfo.Address2));
                cmd.Parameters.Add(new MySqlParameter("@postalCode", customerInfo.ZipCode));
                cmd.Parameters.Add(new MySqlParameter("@phone", customerInfo.Phone));
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

        public Boolean addCustomer(CustomerInfo customerInfo)
        {
            string query = "INSERT INTO customer(customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                                "SELECT @customerName, addressId, @active, @createDate, @createdBy, @lastUpdate, @lastUpdateBy " +
                                "FROM address ORDER BY addressId DESC LIMIT 1";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);

                cmd.Parameters.Add(new MySqlParameter("@customerName", customerInfo.CustomerName));
                cmd.Parameters.Add(new MySqlParameter("@active", customerInfo.Active));
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

        //get customer info to pre-fill in the inpout boxes
        public CustomerInfo getCustomer(int selectedCustomer)
        {
            string query = "SELECT customerId, customerName, address, address2, city, country, postalCode, phone, active " +
                            "FROM customer " +
                            "INNER JOIN address on address.cityId = customer.addressId " +
                            "INNER JOIN city on city.countryId = address.cityId " +
                            "INNER JOIN country on country.countryId = city.countryId " +
                            "WHERE customer.addressId ='" + selectedCustomer + "'";

            try
            {
                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    GlobalMembers.customerInfo.CustomerName = reader["customerName"].ToString();
                    GlobalMembers.customerInfo.Address = reader["address"].ToString();
                    GlobalMembers.customerInfo.Address2 = reader["address2"].ToString();
                    GlobalMembers.customerInfo.City = reader["city"].ToString();
                    GlobalMembers.customerInfo.Country = reader["country"].ToString();
                    GlobalMembers.customerInfo.ZipCode = reader["postalCode"].ToString();
                    GlobalMembers.customerInfo.Phone = reader["phone"].ToString();
                    GlobalMembers.customerInfo.Active = Convert.ToInt32(reader["active"]);
                }

                reader.Close();
                cmd.Dispose();
                return GlobalMembers.customerInfo;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }


        public Boolean updateCustomer(CustomerInfo customerInfo, int selectedCustomerID)
        {
            string query = "UPDATE customer " +
                            "INNER JOIN address ON address.cityId = customer.addressId " +
                            "INNER JOIN city ON city.countryId = address.cityId " +
                            "INNER JOIN country ON country.countryId = city.countryId " +
                            "SET customer.addressId = @selectedCustomerID, customer.customerName=@customerName,customer.active=@active, customer.lastUpdate=@lastUpdate, customer.lastUpdateBy=@lastUpdateBy, " +
                            "address.cityId = @selectedCustomerID, address.address=@address, address.address2=@address2, address.postalCode=@zipCode, address.phone=@phone, address.lastUpdate=@lastUpdate, address.lastUpdateBy=@lastUpdateBy, " +
                            "city.countryId = @selectedCustomerID, city.city=@city, city.lastUpdate=@lastUpdate, city.lastUpdateBy=@lastUpdateBy, " +
                            "country.countryId = @selectedCustomerID, country.country=@country, country.lastUpdate=@lastUpdate, country.lastUpdateBy=@lastUpdateBy " +
                            "WHERE customer.addressId = @selectedCustomerID";

            try
            {

                MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                //information for customer
                cmd.Parameters.Add(new MySqlParameter("@customerName", customerInfo.CustomerName));
                cmd.Parameters.Add(new MySqlParameter("@active", customerInfo.Active));
                //information for address
                cmd.Parameters.Add(new MySqlParameter("@address", customerInfo.Address));
                cmd.Parameters.Add(new MySqlParameter("@address2", customerInfo.Address2));
                cmd.Parameters.Add(new MySqlParameter("@zipCode", customerInfo.ZipCode));
                cmd.Parameters.Add(new MySqlParameter("@phone", customerInfo.Phone));
                //information for city
                cmd.Parameters.Add(new MySqlParameter("@city", customerInfo.City));
                //information for country
                cmd.Parameters.Add(new MySqlParameter("@country", customerInfo.Country));
                //information for all
                cmd.Parameters.Add(new MySqlParameter("@selectedCustomerID", selectedCustomerID));
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

        //delete customer
        public Boolean deleteCustomer(int userId)
        {
            string query = "DELETE customer, address, city, country FROM customer " +
                            "INNER JOIN address on address.cityId = customer.addressId " +
                            "INNER JOIN city on city.countryId = address.cityId " +
                            "INNER JOIN country on country.countryId = city.countryId " +
                            "WHERE customer.addressId ='" + userId + "'";
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
