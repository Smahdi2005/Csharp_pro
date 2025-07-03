
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using university.Entities;

namespace university
{
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private Button studentLoginFormButton;
        private Button masterLoginFormButton;
        private Button adminsLoginFormButton;

        private void InitializeComponent()
        {
            studentLoginFormButton = new Button();
            masterLoginFormButton = new Button();
            adminsLoginFormButton = new Button();
            SuspendLayout();
            // 
            // studentLoginFormButton
            // 
            studentLoginFormButton.Location = new Point(27, 34);
            studentLoginFormButton.Name = "studentLoginFormButton";
            studentLoginFormButton.Size = new Size(228, 42);
            studentLoginFormButton.TabIndex = 0;
            studentLoginFormButton.Text = "Students Login";
            studentLoginFormButton.UseVisualStyleBackColor = true;
            studentLoginFormButton.Click += studentLoginFormButton_Click;
            // 
            // masterLoginFormButton
            // 
            masterLoginFormButton.Location = new Point(27, 96);
            masterLoginFormButton.Name = "masterLoginFormButton";
            masterLoginFormButton.Size = new Size(228, 42);
            masterLoginFormButton.TabIndex = 1;
            masterLoginFormButton.Text = "Maters Login";
            masterLoginFormButton.UseVisualStyleBackColor = true;
            masterLoginFormButton.Click += masterLoginFormButton_Click;
            // 
            // adminsLoginFormButton
            // 
            adminsLoginFormButton.Location = new Point(27, 163);
            adminsLoginFormButton.Name = "adminsLoginFormButton";
            adminsLoginFormButton.Size = new Size(228, 42);
            adminsLoginFormButton.TabIndex = 2;
            adminsLoginFormButton.Text = "Admins Login";
            adminsLoginFormButton.UseVisualStyleBackColor = true;
            adminsLoginFormButton.Click += adminsLoginFormButton_Click;
            // 
            // FirstPage
            // 
            ClientSize = new Size(282, 253);
            Controls.Add(adminsLoginFormButton);
            Controls.Add(masterLoginFormButton);
            Controls.Add(studentLoginFormButton);
            Name = "FirstPage";
            ResumeLayout(false);
        }

        private void studentLoginFormButton_Click(object sender, EventArgs e)
        {
            StudentsLogin studentsLogin = new StudentsLogin();
            studentsLogin.Show();

        }

        private void masterLoginFormButton_Click(object sender, EventArgs e)
        {
            MastersLogin mastersLogin = new MastersLogin();
            mastersLogin.Show();

        }

        private void adminsLoginFormButton_Click(object sender, EventArgs e)
        {
            AdminsLogin adminsLogin = new AdminsLogin();
            adminsLogin.Show();
        }
    }
}
