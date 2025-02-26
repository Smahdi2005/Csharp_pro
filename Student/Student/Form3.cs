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
    public partial class Masters : Form
    {
        public Masters()
        {
            InitializeComponent();
        }
        // passing data from form 1 to 2//
        private string FirstnameFromForm1to3;
        private string lastnameFromForm2to3;
        //defining constructor for students and get data from form 1 //
        public Masters(string firstname, string lastname)
        {
            InitializeComponent();
            // set the data that got//
            FirstnameFromForm1to3 = firstname;
            lastnameFromForm2to3 = lastname;
        }

        private void loginMastersButton_Click(object sender, EventArgs e)
        {
            //cheking the data that is valid or not //
            if (loginfirsnameMastersTextBox.Text == FirstnameFromForm1to3)
            {
                if (loginfirsnameMastersTextBox.Text == lastnameFromForm2to3)
                {
                    MessageBox.Show($"welcome master {FirstnameFromForm1to3} {lastnameFromForm2to3} you logged in");
                }
            }
            else
            {
                MessageBox.Show("Pleae enter valid data");
            }
        }
    }
}
