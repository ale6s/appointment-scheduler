using System;
using System.Globalization;
using System.Windows.Forms;

namespace Scheduling
{
    public class Utility
    {
        /*This utility class will validate all input and user selection
         * The intention of the class was meant to not repeat the same condition over and over
         * also make the code more readible 
         * I decided to make a validator method for each input to give the user a better undestanding on where the error is located
         */

        //validator, checking for empty Strings
        public Boolean titleValid(string userInput)
        {
            if (!String.IsNullOrEmpty(userInput))

                return true;
            else
                MessageBox.Show("Invalid Input for Title, Make sure is not empty", "Title Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        //validator, checking for empty Strings
        public Boolean descriptionValid(string userInput)
        {
            if (!String.IsNullOrEmpty(userInput))

                return true;
            else
                MessageBox.Show("Invalid Input for Description, Make sure is not empty", "Description Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        //validator, checking for empty Strings
        public Boolean locationValid(string userInput)
        {
            if (!String.IsNullOrEmpty(userInput))

                return true;
            else
                MessageBox.Show("Invalid Input for Location, Make sure is not empty", "Location Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        //validator, checking for empty Strings
        public Boolean contactValid(string userInput)
        {
            if (!String.IsNullOrEmpty(userInput))

                return true;
            else
                MessageBox.Show("Invalid Input for Contact, Make sure is not empty", "Contact Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        //validator, checking for empty Strings
        public Boolean typeValid(string userInput)
        {
            if (!String.IsNullOrEmpty(userInput))

                return true;
            else
                MessageBox.Show("Invalid Input for Type, Make sure is not empty", "Type Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        //validator, checking for empty Strings
        public Boolean urlValid(string userInput)
        {
            if (!String.IsNullOrEmpty(userInput))

                return true;
            else
                MessageBox.Show("Invalid Input for URL, Make sure is not empty", "URL Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        //validator, checking if times overlap
        public Boolean dateValid(string datepickedStart, string datepickedEnd, string customerId)
        {
            string startTimeDB;
            string endTimeDB;

            //if there is no apt then ignore this and true
            if (GlobalMembers.userData.getUserStartDate(customerId).Count > 0)
            {

                for (int i = 0; i < GlobalMembers.userData.getUserStartDate(customerId).Count; i++)
                {
                    startTimeDB = GlobalMembers.userData.getUserStartDate(customerId)[i];
                    endTimeDB = GlobalMembers.userData.getUserEndDate(customerId)[i];

                    if (DateTime.Parse(datepickedStart, CultureInfo.InvariantCulture) < DateTime.Parse(startTimeDB, CultureInfo.InvariantCulture) &&
                        DateTime.Parse(datepickedEnd, CultureInfo.InvariantCulture) < DateTime.Parse(startTimeDB, CultureInfo.InvariantCulture) ||
                        DateTime.Parse(datepickedStart, CultureInfo.InvariantCulture) > DateTime.Parse(endTimeDB, CultureInfo.InvariantCulture) &&
                        DateTime.Parse(datepickedEnd, CultureInfo.InvariantCulture) > DateTime.Parse(endTimeDB, CultureInfo.InvariantCulture))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("There is already an Appointment in between this time, please change time - The overlapping Appointment goes from\n" + startTimeDB + " and Goes until " + endTimeDB,
                            "Overlapping Times Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }
                }
            }
            else
            {
                return true;
            }
            return false;
        }
        //make sure start time is less than end time
        public Boolean dateStartLessThanEndValid(string datepickedStart, string datepickedEnd)
        {
            if (DateTime.Parse(datepickedStart, CultureInfo.InvariantCulture) < DateTime.Parse(datepickedEnd, CultureInfo.InvariantCulture))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Start Time cannot be bigger than End Time",
                    "Start must be Less than End Time", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;
        }
        //make sure time is bigger than todays date
        public Boolean dateBiggeTodayValid(string datepickedStart, string datepickedEnd)
        {
            if (DateTime.Parse(datepickedStart, CultureInfo.InvariantCulture) > DateTime.Now && DateTime.Parse(datepickedEnd, CultureInfo.InvariantCulture) > DateTime.Now)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Start Time and End time must be later than today time",
                    "Start End time Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;
        }
        //Schedule is the 7 days a week from 7am  to 7pm
        public Boolean timeCheckValid(string datepickedStart, string datepickedEnd)
        {
            string scheduleTimeStart = "07:00";
            string scheduleTimeEnd = "19:00";

            if (DateTime.Parse(datepickedStart, CultureInfo.InvariantCulture) >= DateTime.Parse(scheduleTimeStart, CultureInfo.InvariantCulture) &&
                DateTime.Parse(datepickedStart, CultureInfo.InvariantCulture) <= DateTime.Parse(scheduleTimeEnd, CultureInfo.InvariantCulture) &&
                DateTime.Parse(datepickedEnd, CultureInfo.InvariantCulture) >= DateTime.Parse(scheduleTimeStart, CultureInfo.InvariantCulture) &&
                DateTime.Parse(datepickedEnd, CultureInfo.InvariantCulture) <= DateTime.Parse(scheduleTimeEnd, CultureInfo.InvariantCulture))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Hospital is currently close at this Schedule time is from 7AM to 7PM 7 Days a week",
                    "Schedule Time error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return false;
        }

        //validator, checking for empty Strings
        public Boolean nameValid(string userInput)
        {
            if (!String.IsNullOrEmpty(userInput))
                return true;
            else
                MessageBox.Show("Invalid Input for Name, Make sure is not empty", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        //validator, checking for empty Strings
        public Boolean customerIDValid(string userInput)
        {
            if (!String.IsNullOrEmpty(userInput))
                return true;
            else
                MessageBox.Show("Invalid Input for Customer ID, Make sure is not empty", "Customer ID Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        //validator, checking for empty Strings
        public Boolean address1Valid(string userInput)
        {
            if (!String.IsNullOrEmpty(userInput))

                return true;
            else
                MessageBox.Show("Invalid Input for Address 1, Make sure is not empty", "Address 1 Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        //validator, checking for empty Strings
        /*public Boolean address2Valid(string userInput)
        {
            if (!String.IsNullOrEmpty(userInput))

                return true;
            else
                MessageBox.Show("Invalid Input for Address 2, Make sure is not empty", "Address 2 Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }*/

        //validator, checking for empty integer and making sure is integer 
        public Boolean zipCodeValid(string userInput)
        {
            int num = -1;
            if (!String.IsNullOrEmpty(userInput))
                if (int.TryParse(userInput, out num))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("ZipCoode only accepts integer numbers", "ZipCoode Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            else
                MessageBox.Show("Invalid Input for ZipCode, Make sure is not empty", "ZipCoode Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }

        //validator, checking for empty Strings
        public Boolean phoneValid(string userInput)
        {
            if (!String.IsNullOrEmpty(userInput))

                return true;
            else
                MessageBox.Show("Invalid Input for Phone, Make sure is not empty", "Phone Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        public Boolean cityValid(string cityInput)
        {
            if (!String.IsNullOrEmpty(cityInput))

                return true;
            else
                MessageBox.Show("Please make a City Selection", "City Dropdown Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        public Boolean activeValid(string activeInput)
        {
            if (!String.IsNullOrEmpty(activeInput))

                return true;
            else
                MessageBox.Show("Please seelct Account Status", "Account Status Dropdown Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        public Boolean loginValidENG(string username, string pws)
        {
            if (!String.IsNullOrEmpty(pws) && !String.IsNullOrEmpty(username))

                return true;
            else
                MessageBox.Show("Username or Password are empty", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
        public Boolean loginValidSPA(string username, string pws)
        {
            if (!String.IsNullOrEmpty(pws) && !String.IsNullOrEmpty(username))

                return true;
            else
                MessageBox.Show("Nombre de Usuario o Contrasena es Incorrecta", "Error al iniciar Session", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
        }
    }
}
