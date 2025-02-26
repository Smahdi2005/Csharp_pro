using Student.models;
namespace Student

    /*
     forth edition changes:
        
        1) students login form and masters login form got caperate
        2) property changed
        3) data transfered from form1 to the others
        4) null and dirties datas controled better
        5) constructors set for objects and forms
        6) showing messages
    */
{
    public partial class Users : Form
    {
        //define a list of students//
        List<Students> Students = new();


        public Users()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //add student to list
            Students student = new Students(firstNameTextBox.Text, lastNameTextBox.Text, nationalCodeTextBox.Text);
            Students.Add(student);

            //set properties for textboxes and labels//
            student.FirstName = firstNameTextBox.Text;
            student.LastName = lastNameTextBox.Text;
            student.Nationalcode = nationalCodeTextBox.Text;

            MessageBox.Show("you are registered");
            //checking role of the user//
            if(studentRoleCheckBox.Checked = true)
            {
                masterRolecheckBox.Checked = false;
                student.UserRole = "Student";
                students StudentForm = new students(firstNameTextBox.Text,lastNameTextBox.Text, nationalCodeTextBox.Text);
                StudentForm.Show(); //student form will open//

            }
            if (masterRolecheckBox.Checked = true)
            {
                studentRoleCheckBox.Checked = false;
                student.UserRole = "Master";
                Masters MasterForm = new Masters(firstNameTextBox.Text, lastNameTextBox.Text);
                MasterForm.Show(); // master form will open//
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
