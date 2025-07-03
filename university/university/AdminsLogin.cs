
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using university.bisunesse;
using university.Entities;

namespace university
{
    public partial class AdminsLogin : Form
    {

        public AdminsLogin()
        {
            InitializeComponent();



        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            AdminBusiness adminBusiness = new AdminBusiness();
            bool ValidAdmin = adminBusiness.GetDataFromDb(userName, password);
            if (ValidAdmin)
            {
                MessageBox.Show("Sucessfull");
            }
            else
            {
                MessageBox.Show("Unsucessfull");
            }

            





        }
    }
}
