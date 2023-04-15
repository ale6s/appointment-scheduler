using System;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class addCustomerForm : Form
    {
        private int active;
        public addCustomerForm()
        {
            InitializeComponent();
        }

        //loading cities into comboBox
        private void addCustomerForm_Load(object sender, EventArgs e)
        {
            string[] cities = new string[] { "New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Mexico City", "Tijuana", "Ecatepec", "León", "Puebla" };

            for (int i = 0; i < cities.Length; i++)
            {
                comboBoxCity.Items.Add(cities[i]);
            }
            comboBoxActive.Items.Add("Active");
            comboBoxActive.Items.Add("Disabled");
        }

        //base on user seelction contry for dropdwon will change
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

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (GlobalMembers.utility.nameValid(textBoxCustomerName.Text) &&
                GlobalMembers.utility.address1Valid(textBoxAddress1.Text) &&
                GlobalMembers.utility.cityValid(comboBoxCity.Text) &&
                GlobalMembers.utility.zipCodeValid(textBoxZipCode.Text) &&
                GlobalMembers.utility.phoneValid(textBoxPhone.Text) &&
                GlobalMembers.utility.activeValid(comboBoxActive.Text))
            {

                GlobalMembers.customer.addCountry(new CustomerInfo(textBoxCustomerName.Text, textBoxAddress1.Text, textBoxAddress2.Text, comboBoxCity.Text, textBoxCountry.Text, textBoxZipCode.Text, textBoxPhone.Text, active));
                GlobalMembers.customer.addCity(new CustomerInfo(textBoxCustomerName.Text, textBoxAddress1.Text, textBoxAddress2.Text, comboBoxCity.Text, textBoxCountry.Text, textBoxZipCode.Text, textBoxPhone.Text, active));
                GlobalMembers.customer.addAddress(new CustomerInfo(textBoxCustomerName.Text, textBoxAddress1.Text, textBoxAddress2.Text, comboBoxCity.Text, textBoxCountry.Text, textBoxZipCode.Text, textBoxPhone.Text, active));
                GlobalMembers.customer.addCustomer(new CustomerInfo(textBoxCustomerName.Text, textBoxAddress1.Text, textBoxAddress2.Text, comboBoxCity.Text, textBoxCountry.Text, textBoxZipCode.Text, textBoxPhone.Text, active));

                GlobalMembers.mainForm.mainTableData();
                Console.WriteLine("Saving New Customer");
                GlobalMembers.mainForm.Show();
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Canceled");
            GlobalMembers.mainForm.Show();
            this.Close();
        }


    }
}
