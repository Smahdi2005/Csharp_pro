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

namespace university
{
    public partial class StudentsChangePassword : Form
    {
        public StudentsChangePassword()
        {
            InitializeComponent();
        }

        private void newPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            string mobileNumber = mobileNumberTextBox.Text.Trim();
            string newPassword = newPasswordTextBox.Text.Trim();
               
            if (string.IsNullOrEmpty(mobileNumber) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("please eneter mobile number and new password");
                return;
            }
            StudentBusiness studentBusiness = new StudentBusiness();
            if (studentBusiness.ChangePassword(mobileNumber,newPassword))
            {
                if(confirmNewPasswordTextBox.Text==newPasswordTextBox.Text)
                {
                    MessageBox.Show("password change successfully");
                    return;
                }

            }
            else
            {
                MessageBox.Show("password didn't changed");
            }
        }
    }
}
