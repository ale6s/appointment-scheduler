using System;
using System.Data;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class notificationForm : Form
    {
        public notificationForm()
        {
            InitializeComponent();
        }

        private void notification_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getAppointmentNotification());
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["appointmentId"].HeaderText = "ID";
            dataGridView1.Columns["appointmentId"].Width = 50;
            dataGridView1.Columns["customerId"].Visible = false;
            dataGridView1.Columns["userId"].Visible = false;
            dataGridView1.Columns["title"].HeaderText = "Title";
            dataGridView1.Columns["title"].Width = 150;
            dataGridView1.Columns["description"].HeaderText = "Description";
            dataGridView1.Columns["description"].Width = 180;
            dataGridView1.Columns["location"].HeaderText = "Location";
            dataGridView1.Columns["contact"].HeaderText = "Contact";
            dataGridView1.Columns["type"].HeaderText = "Type";
            dataGridView1.Columns["url"].Visible = false;
            dataGridView1.Columns["start"].HeaderText = "Start";
            dataGridView1.Columns["start"].Width = 115;
            dataGridView1.Columns["end"].HeaderText = "End";
            dataGridView1.Columns["end"].Width = 115;
            dataGridView1.Columns["createDate"].HeaderText = "Create Date";
            dataGridView1.Columns["createDate"].Width = 115;
            dataGridView1.Columns["LastUpdate"].HeaderText = "Last Update";
            dataGridView1.Columns["LastUpdate"].Width = 115;
            dataGridView1.Columns["lastUpdateBy"].Visible = false;
            dataGridView1.Columns["createdBy"].Visible = false;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Notification was closed!!");
            //GlobalMembers.mainForm.Show();
            this.Close();
        }

    }
}
