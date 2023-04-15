using System;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class addAppointmentForm : Form
    {
        public int active;
        public addAppointmentForm()
        {
            InitializeComponent();
        }

        private void addAppointmentForm_Load(object sender, EventArgs e)
        {
            textBoxAptId.Text = "Auto Generates";
            textBoxUserId.Text = "Auto Generates";

            //adding all customer id on Combox
            /*for (int i = 0; i < GlobalMembers.userData.getAllCustomerId().Count; i++)
            {
                comboBoxcustomerId.Items.Add(GlobalMembers.userData.getAllCustomerId()[i]);
            }*/

            //Lambda expression - Using it because it looks cleaner and leess code, previews code use for this is above
            GlobalMembers.userData.getAllCustomerId().ForEach(customerId => comboBoxcustomerId.Items.Add(customerId));

        }

        //If succes saving data and redirecting user to Main Screen
        private void saveBtn_Click(object sender, EventArgs e)
        {
            //if all info is correct then add scuessfully add appointment
            if (GlobalMembers.utility.customerIDValid(comboBoxcustomerId.Text) &&
                GlobalMembers.utility.titleValid(textBoxTitle.Text) &&
                GlobalMembers.utility.descriptionValid(textBoxDescription.Text) &&
                GlobalMembers.utility.locationValid(textBoxLocation.Text) &&
                GlobalMembers.utility.contactValid(textBoxContact.Text) &&
                GlobalMembers.utility.typeValid(textBoxType.Text) &&
                GlobalMembers.utility.urlValid(textBoxUrl.Text) &&
                GlobalMembers.utility.dateValid(dateTimePickerStartTime.Value.ToString(), dateTimePickerEndTime.Value.ToString(), comboBoxcustomerId.Text) &&
                GlobalMembers.utility.dateStartLessThanEndValid(dateTimePickerStartTime.Value.ToString(), dateTimePickerEndTime.Value.ToString()) &&
                GlobalMembers.utility.dateBiggeTodayValid(dateTimePickerStartTime.Value.ToString(), dateTimePickerEndTime.Value.ToString()) &&
                GlobalMembers.utility.timeCheckValid(dateTimePickerStartTime.Value.ToString("HH:mm"), dateTimePickerEndTime.Value.ToString("HH:mm")))
            {
                GlobalMembers.appointment.addAppointment(new AppointmentInfo(Convert.ToInt32(comboBoxcustomerId.Text), textBoxTitle.Text, textBoxDescription.Text, textBoxLocation.Text, textBoxContact.Text, textBoxType.Text, textBoxUrl.Text, dateTimePickerStartTime.Value.ToString("yyyyMMddHHmmss"), dateTimePickerEndTime.Value.ToString("yyyyMMddHHmmss")));

                GlobalMembers.mainForm.mainTableData();
                Console.WriteLine("Saving New appointment");
                GlobalMembers.mainForm.Show();
                this.Close();
            }
        }

        private void comboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxName.Text = GlobalMembers.userData.getAllCustomerName(Convert.ToInt32(comboBoxcustomerId.Text));
        }

        //Cancel, redirecting back to Main Form
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Canceled");
            GlobalMembers.mainForm.Show();
            this.Close();
        }

    }
}
