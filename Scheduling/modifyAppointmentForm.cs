using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class modifyAppointmentForm : Form
    {
        private int selectedAppointmentID;
        public modifyAppointmentForm(int selectedId)
        {
            InitializeComponent();
            //prefilling all input boxes bases on the user selection
            this.selectedAppointmentID = selectedId;
            textBoxAppointmentId.Text = selectedAppointmentID.ToString();
            textBoxUserId.Text = GlobalMembers.userData.getCurrentUserID();
            textBoxTitle.Text = GlobalMembers.appointment.getAppointment(selectedId).Title;
            textBoxDescription.Text = GlobalMembers.appointment.getAppointment(selectedId).Description;
            textBoxLocation.Text = GlobalMembers.appointment.getAppointment(selectedId).Location;
            textBoxContact.Text = GlobalMembers.appointment.getAppointment(selectedId).Contact;
            textBoxType.Text = GlobalMembers.appointment.getAppointment(selectedId).Type;
            textBoxUrl.Text = GlobalMembers.appointment.getAppointment(selectedId).Url;
            dateTimePickerStartTime.Text = GlobalMembers.appointment.getAppointment(selectedId).StartDate;
            dateTimePickerEndTime.Text = GlobalMembers.appointment.getAppointment(selectedId).EndDate;


            /*for (int i = 0; i < GlobalMembers.userData.getAllCustomerId().Count; i++)
                {
                    comboBoxcustomerId.Items.Add(GlobalMembers.userData.getAllCustomerId()[i]);
                }*/

            //Lambda expression - Using it because it looks cleaner and leess code, previews code use for this is above
            GlobalMembers.userData.getAllCustomerId().ForEach(customerId => comboBoxcustomerId.Items.Add(customerId));

            comboBoxcustomerId.Text = GlobalMembers.appointment.getAppointment(selectedId).CustomerId.ToString();
        }

        private void comboBoxcustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxName.Text = GlobalMembers.userData.getAllCustomerName(Convert.ToInt32(comboBoxcustomerId.Text));
        }

        //If succes saving data and redirecting user to Main Screen
        private void saveBtn_Click(object sender, EventArgs e)
        {
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
                GlobalMembers.appointment.updateAppointment(new AppointmentInfo(Convert.ToInt32(comboBoxcustomerId.Text), textBoxTitle.Text, textBoxDescription.Text, textBoxLocation.Text, textBoxContact.Text, textBoxType.Text, textBoxUrl.Text, dateTimePickerStartTime.Value.ToString("yyyyMMddHHmmss"), dateTimePickerEndTime.Value.ToString("yyyyMMddHHmmss")), selectedAppointmentID);

                GlobalMembers.mainForm.mainTableData();
                Console.WriteLine("Saving Changes appointment");
                GlobalMembers.mainForm.Show();
                this.Close();
            }
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
