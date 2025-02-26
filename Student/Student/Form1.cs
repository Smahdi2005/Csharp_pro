using Student.models;

namespace Student
{
    public partial class Form1 : Form
    {
        //define a list of students//
        List<Students> Students = new();


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //add student to list
            Students student = new Students(firstNameTextBox.Text, lastNameTextBox.Text);
            Students.Add(student);

            //set properties for textboxes and labels//
            student.FirstName = firstNameTextBox.Text;
            student.LastName = lastNameTextBox.Text;
            student.Nationalcode = nationalCodeTextBox.Text;

            showRegisterLabel.Text = "you registered";

            if(studentRoleCheckBox.Checked = true)
            {
                student.UserRole = "Student";
            }
            if (masterRolecheckBox.Checked = true)
            {
                student.UserRole = "Master";
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //handel eror//
            try
            {
                //login check//
                if (loginFirstNameTextBox.Text == firstNameTextBox.Text)
                {
                    if (loginLastNameTextBox.Text == lastNameTextBox.Text)
                    {
                        showLabel.Text = "you logged in ";
                    }
                }
                else
                {
                    showerorLabel.Text = "please enter valid data";
                }
            }
            catch
            {
          
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void studentRoleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            studentRoleCheckBox.Checked = true;
            
        }

        private void masterRolecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            masterRolecheckBox.Checked = true;
        }
    }
}
