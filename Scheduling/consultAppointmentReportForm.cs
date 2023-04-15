using System;
using System.Data;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class consultAppointmentReportForm : Form
    {
        public consultAppointmentReportForm()
        {
            InitializeComponent();
        }

        //reddirecting user to main form
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            GlobalMembers.mainForm.mainTableData();
            Console.WriteLine("Closing Consult Appointments Report");
            GlobalMembers.mainForm.Show();
            this.Close();
        }

        private void consultAppointmentReportForm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < GlobalMembers.userData.getAllCustomerId().Count; i++)
            {
                comboBoxcustomerId.Items.Add(GlobalMembers.userData.getAllCustomerId()[i]);
            }
        }
        // base on the user ID selection the information below will change 
        private void comboBoxcustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxName.Text = GlobalMembers.userData.getAllCustomerName(Convert.ToInt32(comboBoxcustomerId.Text));

            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getAppointmnetsByUser(comboBoxcustomerId.Text));
            dataGridView1.DataSource = dt1;

            dataGridView1.Columns["appointmentId"].HeaderText = "Appointment ID";
            dataGridView1.Columns["customerId"].HeaderText = "Customer ID";
            dataGridView1.Columns["userId"].HeaderText = "User ID";
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
        }
    }
}
