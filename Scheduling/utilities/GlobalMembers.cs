using MySql.Data.MySqlClient;
using Scheduling.utilities;
using System;

namespace Scheduling
{
    static class GlobalMembers
    {
        public static loginForm loginForm = new loginForm();
        public static mainForm mainForm = new mainForm();
        public static Utility utility = new Utility();
        public static MySqlConnection DBConn = Connection.conn;
        public static Login login = new Login();
        public static Reports reports = new Reports();
        public static Customer customer = new Customer();
        public static UserData userData = new UserData();
        public static CustomerInfo customerInfo = new CustomerInfo();
        public static AppointmentInfo appointmentInfo = new AppointmentInfo();
        public static Appointment appointment = new Appointment();
        public static Boolean notificationNew = true;

    }

}
