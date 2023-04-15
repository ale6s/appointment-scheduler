using System;
using System.Data;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            mainTableData();
        }

        public void mainTableData()
        {

            if (GlobalMembers.DBConn.State == ConnectionState.Open)
            {
                DataTable dt1 = new DataTable();
                dt1.Load(GlobalMembers.reports.getUpcomingAppointment());
                dataGridView1.DataSource = dt1;

                dataGridView1.Columns["appointmentId"].HeaderText = "Appointment ID";
                dataGridView1.Columns["customerId"].Visible = false;
                dataGridView1.Columns["userId"].Visible = false;
                dataGridView1.Columns["title"].HeaderText = "Title";
                dataGridView1.Columns["title"].Width = 150;
                dataGridView1.Columns["description"].HeaderText = "Description";
                dataGridView1.Columns["description"].Width = 180;
                dataGridView1.Columns["location"].HeaderText = "Location";
                dataGridView1.Columns["contact"].HeaderText = "Contact";
                dataGridView1.Columns["type"].HeaderText = "Type";
                dataGridView1.Columns["url"].HeaderText = "URL";
                dataGridView1.Columns["start"].HeaderText = "Start";
                dataGridView1.Columns["start"].Width = 115;
                dataGridView1.Columns["end"].HeaderText = "End";
                dataGridView1.Columns["end"].Width = 115;
                dataGridView1.Columns["createDate"].HeaderText = "Create Date";
                dataGridView1.Columns["createDate"].Width = 115;
                dataGridView1.Columns["LastUpdate"].HeaderText = "Last Update";
                dataGridView1.Columns["LastUpdate"].Width = 115;
                dataGridView1.Columns["lastUpdateBy"].HeaderText = "Last Update By";
                dataGridView1.Columns["createdBy"].HeaderText = "Created By";


                DataTable dt2 = new DataTable();
                dt2.Load(GlobalMembers.reports.getAllCustomers());
                dataGridView2.DataSource = dt2;

                dataGridView2.Columns["customerId"].HeaderText = "User ID";
                dataGridView2.Columns["customerName"].HeaderText = "Name";
                dataGridView2.Columns["customerName"].Width = 115;
                dataGridView2.Columns["active"].HeaderText = "Active";
                dataGridView2.Columns["address"].HeaderText = "Address";
                dataGridView2.Columns["address"].Width = 115;
                dataGridView2.Columns["address2"].HeaderText = "Address 2";
                dataGridView2.Columns["address2"].Width = 115;
                dataGridView2.Columns["postalCode"].HeaderText = "ZipCode";
                dataGridView2.Columns["phone"].HeaderText = "Phone #";
                dataGridView2.Columns["city"].HeaderText = "City";
                dataGridView2.Columns["country"].HeaderText = "Country";
                dataGridView2.Columns["createDate"].HeaderText = "Create Date";
                dataGridView2.Columns["createDate"].Width = 115;
                dataGridView2.Columns["LastUpdate"].HeaderText = "Last Update";
                dataGridView2.Columns["LastUpdate"].Width = 115;
                dataGridView2.Columns["lastUpdateBy"].HeaderText = "Last Update By";
                dataGridView2.Columns["address"].Width = 115;
                dataGridView2.Columns["createdBy"].HeaderText = "Created By";


            }
            else
            {
                Console.WriteLine("Check Database, unable to communicate with the DB");
            }

            //will check for appointment with in 15 mins
            if (GlobalMembers.reports.checkAppointmentNotification() && GlobalMembers.notificationNew)
            {
                new notificationForm().ShowDialog();
                GlobalMembers.notificationNew = false;
            }
            if (GlobalMembers.reports.checkAppointmentNotification())
            {
                buttonNotification.ForeColor = System.Drawing.Color.Red;
                buttonNotification.BackColor = System.Drawing.Color.Gold;

            }
        }


        //Add new Appointment, redirect
        private void addAptBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Redirecting user to Add Form");
            this.Hide();
            new addAppointmentForm().ShowDialog();
        }

        //open modify form, with values from selected row
        private void modifyAptBtn_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Console.WriteLine("Redirecting user to Modify Form");
            this.Hide();
            new modifyAppointmentForm(selectedID).ShowDialog();
        }
        //delete selected customer
        private void deleteAptBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you Sure you want to delete this Appointment?", "Are you sure?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //selected if from customer
                int selectedID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                GlobalMembers.appointment.deleteAppointment(selectedID);
                mainTableData();
            }
        }
        //Add New Customer, reddirecting to Add new Customer Form
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Redirecting user to Add Customer");
            this.Hide();
            new addCustomerForm().ShowDialog();
        }

        //reddirecting user to Edit customert with selected row values
        private void modifyCustomerBtn_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            Console.WriteLine("Redirecting user to modify Customer");
            this.Hide();
            new modifyCustomerForm(selectedID).ShowDialog();
        }

        //delete selected customer
        private void deleteCustomerBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you Sure you want to delete this Customer?", "Are you sure?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                //selected if from customer
                int selectedID = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                GlobalMembers.customer.deleteCustomer(selectedID);
                mainTableData();
            }
        }

        //Open Appointnments history Form
        private void viewAptBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Redirecting user to All Appointmnets");
            this.Hide();
            new viewAppointmentForm().ShowDialog();
        }

        //Open report Appointment
        private void reportAptBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Redirecting user to Report Appointmnets");
            this.Hide();
            new viewAppointmentTypeReportForm().ShowDialog();
        }

        //open Consutl appointment Report
        private void consultAptBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Redirecting user to Consult Appointmnets Report");
            this.Hide();
            new consultAppointmentReportForm().ShowDialog();
        }

        //open Customer Appointment form
        private void customerAptBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Redirecting user to Customer Appointmnets Report");
            this.Hide();
            new appointmentCustomerReportForm().ShowDialog();
        }

        //Redirrect user to main Screen
        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you Sure you want to Log Out?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                Console.WriteLine("Loging Out, Reddirecting to Login Page");
                GlobalMembers.notificationNew = true;
                this.Hide();
                GlobalMembers.loginForm.Show();
                //this.Close();
            }
            else
            {
                Console.WriteLine("session still active");
            }
        }


        //Exit Program
        private void exitBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you Sure you want to Exit?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                Console.WriteLine("GoodBye!!");
                Application.Exit();
            }
            else
            {
                Console.WriteLine("session still active");
            }
        }

        private void buttonNotification_Click(object sender, EventArgs e)
        {
            new notificationForm().Show();
            Console.WriteLine("opening Notification window.");
        }

    }
}
