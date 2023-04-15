using System;
using System.Data;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class appointmentCustomerReportForm : Form
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public appointmentCustomerReportForm()
        {
            InitializeComponent();
        }

        private void appointmentCustomerReportForm_Load(object sender, EventArgs e)
        {
            //month radio will be checked base on todays month
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
            dt1.Load(GlobalMembers.reports.getMontlyCountReportByUser(String.Format("{0:MMMM}", DateTime.Now)));
            dataGridView1.DataSource = dt1;
        }
        /**
         * Base on user selection information will change base on the month selected
         * */
        private void janRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getMontlyCountReportByUser(months[0]));
            dataGridView1.DataSource = dt1;
        }

        private void febRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getMontlyCountReportByUser(months[1]));
            dataGridView1.DataSource = dt1;
        }

        private void marRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getMontlyCountReportByUser(months[2]));
            dataGridView1.DataSource = dt1;
        }

        private void aprRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getMontlyCountReportByUser(months[3]));
            dataGridView1.DataSource = dt1;
        }

        private void mayRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getMontlyCountReportByUser(months[4]));
            dataGridView1.DataSource = dt1;
        }

        private void junRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getMontlyCountReportByUser(months[5]));
            dataGridView1.DataSource = dt1;
        }

        private void julRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getMontlyCountReportByUser(months[6]));
            dataGridView1.DataSource = dt1;
        }

        private void augRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getMontlyCountReportByUser(months[7]));
            dataGridView1.DataSource = dt1;
        }

        private void sepRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getMontlyCountReportByUser(months[8]));
            dataGridView1.DataSource = dt1;
        }

        private void octRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getMontlyCountReportByUser(months[9]));
            dataGridView1.DataSource = dt1;
        }

        private void novRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getMontlyCountReportByUser(months[10]));
            dataGridView1.DataSource = dt1;
        }

        private void decRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1.Load(GlobalMembers.reports.getMontlyCountReportByUser(months[11]));
            dataGridView1.DataSource = dt1;
            dataGridView1.Columns["concat(customer.customerName,' Count: ', COUNT(appointment.customerId))"].HeaderText = "# of Appointments By Customer Name";
            dataGridView1.Columns["concat(customer.customerName,' Count: ', COUNT(appointment.customerId))"].Width = 180;
        }

        //reddirecting user back to main form
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Closing Appointments Customer Report");
            GlobalMembers.mainForm.Show();
            this.Close();
        }

    }
}
