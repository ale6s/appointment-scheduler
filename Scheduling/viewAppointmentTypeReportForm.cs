using System;
using System.Data;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class viewAppointmentTypeReportForm : Form
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public viewAppointmentTypeReportForm()
        {
            InitializeComponent();
        }

        private void viewAppointmentTypeReportForm_Load(object sender, EventArgs e)
        {

            if (String.Format("{0:MMMM}", DateTime.Now) == months[0])
            {
                janRadio.Checked = true;
            }
            else if (String.Format("{0:MMMM}", DateTime.Now) == months[1])
            {
                febRadio.Checked = true;
            }
            else if (String.Format("{0:MMMM}", DateTime.Now) == months[2])
            {
                marRadio.Checked = true;
            }
            else if (String.Format("{0:MMMM}", DateTime.Now) == months[3])
            {
                aprRadio.Checked = true;
            }
            else if (String.Format("{0:MMMM}", DateTime.Now) == months[4])
            {
                mayRadio.Checked = true;
            }
            else if (String.Format("{0:MMMM}", DateTime.Now) == months[5])
            {
                junRadio.Checked = true;
            }
            else if (String.Format("{0:MMMM}", DateTime.Now) == months[6])
            {
                julRadio.Checked = true;
            }
            else if (String.Format("{0:MMMM}", DateTime.Now) == months[7])
            {
                augRadio.Checked = true;
            }
            else if (String.Format("{0:MMMM}", DateTime.Now) == months[8])
            {
                octRadio.Checked = true;
            }
            else if (String.Format("{0:MMMM}", DateTime.Now) == months[9])
            {
                novRadio.Checked = true;
            }
            else if (String.Format("{0:MMMM}", DateTime.Now) == months[10])
            {
                sepRadio.Checked = true;
            }
            else if (String.Format("{0:MMMM}", DateTime.Now) == months[11])
            {
                decRadio.Checked = true;
            }

            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getTypeOfAppointment(String.Format("{0:MMMM}", DateTime.Now)));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].HeaderText = "# of Appointments By Type";
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].Width = 180;
        }

        //closing, reddirecting back to main form
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            GlobalMembers.mainForm.mainTableData();
            Console.WriteLine("Closing Report Appointments");
            GlobalMembers.mainForm.Show();
            this.Close();
        }

        private void janRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getTypeOfAppointment(months[0]));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].HeaderText = "# of Appointments By Type";
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].Width = 180;
        }

        private void febRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getTypeOfAppointment(months[1]));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].HeaderText = "# of Appointments By Type";
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].Width = 180;
        }

        private void marRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getTypeOfAppointment(months[2]));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].HeaderText = "# of Appointments By Type";
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].Width = 180;
        }

        private void aprRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getTypeOfAppointment(months[3]));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].HeaderText = "# of Appointments By Type";
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].Width = 180;
        }

        private void mayRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getTypeOfAppointment(months[4]));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].HeaderText = "# of Appointments By Type";
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].Width = 180;
        }

        private void junRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getTypeOfAppointment(months[5]));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].HeaderText = "# of Appointments By Type";
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].Width = 180;
        }

        private void julRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getTypeOfAppointment(months[6]));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].HeaderText = "# of Appointments By Type";
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].Width = 180;
        }

        private void augRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getTypeOfAppointment(months[7]));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].HeaderText = "# of Appointments By Type";
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].Width = 180;
        }

        private void sepRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getTypeOfAppointment(months[8]));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].HeaderText = "# of Appointments By Type";
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].Width = 180;
        }

        private void octRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getTypeOfAppointment(months[9]));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].HeaderText = "# of Appointments By Type";
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].Width = 180;
        }

        private void novRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getTypeOfAppointment(months[10]));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].HeaderText = "# of Appointments By Type";
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].Width = 180;
        }

        private void decRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getTypeOfAppointment(months[11]));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].HeaderText = "# of Appointments By Type";
            dataGridView1.Columns["concat(type,' Count: ', COUNT(type))"].Width = 180;
        }
    }
}
