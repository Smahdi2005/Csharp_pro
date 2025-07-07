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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            string userName = userNameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();
            StudentBusiness studentBusiness = new StudentBusiness();
            Student student = studentBusiness.GetDataFromDb(userName, password);

            if (student != null)
            {
                // لاگین موفق
                StudentForm form = new StudentForm(student);
                form.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid Data.");
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            StudentsChangePassword studentsChangePassword = new StudentsChangePassword();
            studentsChangePassword.Show();
        }
    }
}
