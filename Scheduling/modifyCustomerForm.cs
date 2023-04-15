using System;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class modifyCustomerForm : Form

    {
        private int active;
        private int selectedCustomerID;
        public modifyCustomerForm(int selectedId)
        {
            InitializeComponent();
            //prefilling all input boxes bases on the user selection
            this.selectedCustomerID = selectedId;
            textBoxCustomerId.Text = selectedId.ToString();
            textBoxCustomerName.Text = GlobalMembers.customer.getCustomer(selectedId).CustomerName;
            textBoxAddress1.Text = GlobalMembers.customer.getCustomer(selectedId).Address;
            textBoxAddress2.Text = GlobalMembers.customer.getCustomer(selectedId).Address2;
            comboBoxCity.Text = GlobalMembers.customer.getCustomer(selectedId).City;
            textBoxCountry.Text = GlobalMembers.customer.getCustomer(selectedId).Country;
            textBoxZipCode.Text = GlobalMembers.customer.getCustomer(selectedId).ZipCode;
            textBoxPhone.Text = GlobalMembers.customer.getCustomer(selectedId).Phone;
            comboBoxActive.Text = GlobalMembers.customer.getCustomer(selectedId).Active.ToString();

        }
        //Saving changes made to selected customer*
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (GlobalMembers.utility.nameValid(textBoxCustomerName.Text) &&
                GlobalMembers.utility.address1Valid(textBoxAddress1.Text) &&
                GlobalMembers.utility.cityValid(comboBoxCity.Text) &&
                GlobalMembers.utility.zipCodeValid(textBoxZipCode.Text) &&
                GlobalMembers.utility.phoneValid(textBoxPhone.Text) &&
                GlobalMembers.utility.activeValid(comboBoxActive.Text))
            {

                GlobalMembers.customer.updateCustomer(new CustomerInfo(textBoxCustomerName.Text, textBoxAddress1.Text, textBoxAddress2.Text, comboBoxCity.Text, textBoxCountry.Text, textBoxZipCode.Text, textBoxPhone.Text, active), selectedCustomerID);

                GlobalMembers.mainForm.mainTableData();
                Console.WriteLine("Saving Changes Customer");
                GlobalMembers.mainForm.Show();
                this.Close();
            }
        }

        //canceling, going back to main form
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Canceled");
            GlobalMembers.mainForm.Show();
            this.Close();
        }
        private void modifyCustomerForm_Load(object sender, EventArgs e)
        {
            string[] cities = new string[] { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Mexico City", "Tijuana", "Ecatepec", "León", "Puebla" };

            for (int i = 0; i < cities.Length; i++)
            {
                comboBoxCity.Items.Add(cities[i]);
            }
            comboBoxActive.Items.Add("Active");
            comboBoxActive.Items.Add("Disabled");

            if (comboBoxActive.Text == "1")
            {
                comboBoxActive.Text = "Active";
            }
            else
            {
                comboBoxActive.Text = "Disabled";
            }

        }
        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCity.SelectedIndex == 0 || comboBoxCity.SelectedIndex == 1 || comboBoxCity.SelectedIndex == 2 || comboBoxCity.SelectedIndex == 3 || comboBoxCity.SelectedIndex == 4)
            {
                textBoxCountry.Text = "USA";
            }
            else
            {
                textBoxCountry.Text = "Mexico";
            }
        }

        private void comboBoxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checking value of active combo box to then inser the corresponding value according to the user selection
            if (comboBoxActive.SelectedIndex == 0)
            {
                active = 1;
            }
            else
            {
                active = 0;
            }
        }


    }
}
