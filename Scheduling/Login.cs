using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Scheduling
{
    class Login
    {
        public Boolean login(string userName, string pws, string currentRegion)
        {
            TextWriter tsw = new StreamWriter(@"..\..\loginInfo.txt", true);

            //checking empty inputs in login form
            if (GlobalMembers.utility.loginValidENG(userName, pws))
            {

                if (GlobalMembers.DBConn.State == ConnectionState.Open)
                {

                    //query to check username and pws match, also if Active=1 then account active, else disabled
                    string query = "SELECT userName, password, active,userId FROM user WHERE userName=@userName AND password=@password ";

                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, GlobalMembers.DBConn);
                        cmd.Parameters.Add(new MySqlParameter("@userName", userName));
                        cmd.Parameters.Add(new MySqlParameter("@password", pws));
                        MySqlDataReader reader = cmd.ExecuteReader();

                        //if username and password match, reader will continue and redirect user to main menu otherwhise error message
                        if (reader.Read())
                        {
                            string dbActive = reader["active"].ToString();
                            string dbUserName = reader["userName"].ToString();
                            string dbUserId = reader["userId"].ToString();


                            //if user account 'active' = 1 user acocunt is disabled if  =0 enable
                            if (dbActive == "0")
                            {
                                //if region is null then it means OS region on user pc is not set to Spanish
                                if (currentRegion == null)
                                {
                                    MessageBox.Show("Account is Disabled", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    MessageBox.Show("Cuenta Esta desabilitada", "Problemas Con la Cuenta Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                //write new line
                                //Writing text to the file.
                                tsw.WriteLine("login failed - at " + DateTime.Now.ToString());
                                tsw.WriteLine("user Name: " + dbUserName);
                                tsw.WriteLine("User ID: " + dbUserId);
                                tsw.WriteLine("Error Code: Account Disabled");
                                tsw.WriteLine("-------------------------------------------- \n");
                                tsw.Close();
                            }
                            else
                            {
                                //Writing text to the file.
                                tsw.WriteLine("login succesfully - at " + DateTime.Now.ToString());
                                tsw.WriteLine("user Name: " + dbUserName);
                                tsw.WriteLine("User ID: " + dbUserId);
                                tsw.WriteLine("Error Code: NONE");
                                tsw.WriteLine("-------------------------------------------- \n");
                                tsw.WriteLine(dbUserId);
                                //Close the file.
                                tsw.Close();

                                //success login, closing seccion to start clean if succes decided to logout and log back in
                                reader.Close();
                                cmd.Dispose();
                                return true;
                            }

                            reader.Close();
                            cmd.Dispose();
                        }
                        else
                        {
                            //if region is null then it means OS region on user pc is not set to Spanish
                            if (currentRegion == null)
                            {
                                MessageBox.Show("Incorrect Username OR Password", "Account Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                MessageBox.Show("Incorrecto nombre de Usuario o Contrasena", "Problemas Con la Cuenta Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                            //Writing text to the file.
                            tsw.WriteLine("login Failed - at " + DateTime.Now.ToString());
                            tsw.WriteLine("user Name: " + userName);
                            tsw.WriteLine("User ID: Unknown");
                            tsw.WriteLine("Error Code: Incorrect Username or Password");
                            tsw.WriteLine("-------------------------------------------- \n");
                            //Close the file.
                            tsw.Close();

                            reader.Close();
                            cmd.Dispose();
                        }

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Unable to communicate with the DataBase", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            tsw.Close();

            return false;
        }

    }
}
