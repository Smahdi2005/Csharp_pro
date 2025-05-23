using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        // passing data from form 1 to 2//
        private string FirstNameFromForm1to2;
        private string LasttNameFromForm1to2;
        //defining constructor for students and get data from form 1 //
        public StudentForm(string firstName, string lastname, string nationalcode)
        {
            InitializeComponent();
            // set the data that got//
            FirstNameFromForm1to2 = firstName;
            LasttNameFromForm1to2 = lastname;

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            
        }

        private void loginStudentsButton_Click(object sender, EventArgs e)
        {
            //cheking the data that is valid or not //
            if (loginFirstNameStudentsTextBox.Text == FirstNameFromForm1to2)
            {
                if (loginLastNameStudentsTextBox.Text == LasttNameFromForm1to2)
                {
                    MessageBox.Show($"wecome student {FirstNameFromForm1to2} {LasttNameFromForm1to2} you loginned succesfully ");
                }
                else
                {
                    MessageBox.Show("Please enter valid data");
                }
            }
        }
    }
}
