using System;
using System.Data;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class viewAppointmentForm : Form
    {
        public viewAppointmentForm()
        {
            InitializeComponent();
        }

        //reddirecting user back to main form
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            GlobalMembers.mainForm.mainTableData();
            Console.WriteLine("Closing All Appointments");
            GlobalMembers.mainForm.Show();
            this.Close();
        }

        private void viewAppointmentForm_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getAllAppointment());
            dataGridView1.DataSource = dt1;

            dataGridView1.Columns["appointmentId"].HeaderText = "Appointment ID";
            dataGridView1.Columns["customerId"].Visible = false;
            dataGridView1.Columns["userId"].Visible = false;
            dataGridView1.Columns["title"].HeaderText = "Title";
            dataGridView1.Columns["description"].HeaderText = "Description";
            dataGridView1.Columns["location"].HeaderText = "Location";
            dataGridView1.Columns["contact"].HeaderText = "Contact";
            dataGridView1.Columns["type"].HeaderText = "Type";
            dataGridView1.Columns["url"].HeaderText = "URL";
            dataGridView1.Columns["start"].HeaderText = "Start";
            dataGridView1.Columns["end"].HeaderText = "End";
            dataGridView1.Columns["createDate"].HeaderText = "Create Date";
            dataGridView1.Columns["LastUpdate"].HeaderText = "Last Update";
            dataGridView1.Columns["lastUpdateBy"].HeaderText = "Last Update By";
            dataGridView1.Columns["createdBy"].HeaderText = "Created By";
        }

        private void allAptRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getAllAppointment());
            dataGridView1.DataSource = dt1;

            dataGridView1.Columns["appointmentId"].HeaderText = "Appointment ID";
            dataGridView1.Columns["customerId"].Visible = false;
            dataGridView1.Columns["userId"].Visible = false;
            dataGridView1.Columns["title"].HeaderText = "Title";
            dataGridView1.Columns["description"].HeaderText = "Description";
            dataGridView1.Columns["contact"].HeaderText = "Contact";
            dataGridView1.Columns["type"].HeaderText = "Type";
            dataGridView1.Columns["url"].HeaderText = "URL";
            dataGridView1.Columns["start"].HeaderText = "Start";
            dataGridView1.Columns["end"].HeaderText = "End";
            dataGridView1.Columns["createDate"].HeaderText = "Create Date";
            dataGridView1.Columns["LastUpdate"].HeaderText = "Last Update";
            dataGridView1.Columns["lastUpdateBy"].HeaderText = "Last Update By";
            dataGridView1.Columns["createdBy"].HeaderText = "Created By";
        }

        private void monthlyAptRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getMontlyAppointment());
            dataGridView1.DataSource = dt1;

            dataGridView1.Columns["appointmentId"].HeaderText = "Appointment ID";
            dataGridView1.Columns["customerId"].Visible = false;
            dataGridView1.Columns["userId"].Visible = false;
            dataGridView1.Columns["title"].HeaderText = "Title";
            dataGridView1.Columns["description"].HeaderText = "Description";
            dataGridView1.Columns["contact"].HeaderText = "Contact";
            dataGridView1.Columns["type"].HeaderText = "Type";
            dataGridView1.Columns["url"].HeaderText = "URL";
            dataGridView1.Columns["start"].HeaderText = "Start";
            dataGridView1.Columns["end"].HeaderText = "End";
            dataGridView1.Columns["createDate"].HeaderText = "Create Date";
            dataGridView1.Columns["LastUpdate"].HeaderText = "Last Update";
            dataGridView1.Columns["lastUpdateBy"].HeaderText = "Last Update By";
            dataGridView1.Columns["createdBy"].HeaderText = "Created By";
        }

        private void weeklyAptRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getWeeklyAppointment());
            dataGridView1.DataSource = dt1;

            dataGridView1.Columns["appointmentId"].HeaderText = "Appointment ID";
            dataGridView1.Columns["customerId"].Visible = false;
            dataGridView1.Columns["userId"].Visible = false;
            dataGridView1.Columns["title"].HeaderText = "Title";
            dataGridView1.Columns["description"].HeaderText = "Description";
            dataGridView1.Columns["contact"].HeaderText = "Contact";
            dataGridView1.Columns["type"].HeaderText = "Type";
            dataGridView1.Columns["url"].HeaderText = "URL";
            dataGridView1.Columns["start"].HeaderText = "Start";
            dataGridView1.Columns["end"].HeaderText = "End";
            dataGridView1.Columns["createDate"].HeaderText = "Create Date";
            dataGridView1.Columns["LastUpdate"].HeaderText = "Last Update";
            dataGridView1.Columns["lastUpdateBy"].HeaderText = "Last Update By";
            dataGridView1.Columns["createdBy"].HeaderText = "Created By";
        }


    }
}
