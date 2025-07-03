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
    public partial class StudentsLogin : Form
    {
        public StudentsLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text;
            string password = passwordTextBox.Text;
            StudentBusiness studentBusiness = new StudentBusiness();
            bool ValidAdmin = studentBusiness.GetDataFromDb(userName, password);
            if (ValidAdmin)
            {
                StudentForm studentForm = new StudentForm();
                studentForm.Show();
            }
            else
            {
                MessageBox.Show("invalid data");
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            StudentsChangePassword studentsChangePassword = new StudentsChangePassword();
            studentsChangePassword.Show();
        }
    }
}
