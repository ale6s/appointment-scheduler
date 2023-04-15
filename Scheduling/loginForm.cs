using MySqlX.XDevAPI.Common;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class loginForm : Form
    {
        private string[] spaRegionCode = { "MX", "AR", "CL", "CO", "CR", "CU", "DO", "EC", "SV", "GT", "HN", "419", "NI", "PA", "PY", "PE", "ES" };
        string currentRegion;
        public loginForm()
        {
            InitializeComponent();
        }


        private void loginForm_Load(object sender, EventArgs e)
        {
            var regionInfo = RegionInfo.CurrentRegion;
            Console.WriteLine("Name: {0}", regionInfo.TwoLetterISORegionName);


            for (int i = 0; i < spaRegionCode.Length; i++)
            {
                //label will change to spanish if the user region is set to one of the ones in the array Default is English
                if (regionInfo.TwoLetterISORegionName == spaRegionCode[i])
                {
                    currentRegion = spaRegionCode[i];
                    label1.Text = "Panel de inicio de sesión";
                    label2.Text = "Nombre de Usuario";
                    label3.Text = "Contraseña";
                    loginBtn.Text = "Iniciar";
                    closeBtn.Text = "Cerrar";
                }
            }
        }

        //If login success procced to Main Screen
        private void loginBtn_Click(object sender, EventArgs e)
        {
            //if statement true then login
            if (GlobalMembers.login.login(userNameBox.Text, passwordBox.Text, currentRegion))
            {
                Console.WriteLine("Login sucess, Reddirecting to Main Screen");
                this.Hide();
                new mainForm().Show();
            }
        }

        //Exist Program
        private void closeBtn_Click(object sender, EventArgs e)
        {
            if (spaRegionCode == null)
            {
                var resultENG = MessageBox.Show("Are you sure you want to Exit the program?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (resultENG == DialogResult.OK)
                {
                    Console.WriteLine("GoodBye!!");
                    Application.Exit();
                }
                else
                {
                    Console.WriteLine("session still active");
                }
            }
            else
            {
                var resultSPA = MessageBox.Show("Esta Seguro que Quiere cerrar el programa?", "Esta Seguro?", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                if (resultSPA == DialogResult.OK)
                {
                    Console.WriteLine("GoodBye!!");
                    Application.Exit();
                }
                else
                {
                    Console.WriteLine("session still active");
                }
            }


        }

    }
}
