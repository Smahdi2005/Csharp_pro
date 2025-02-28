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
            Students student = new Students(usersFirstNameTextBox.Text, usersLastNameTextBox.Text, usersNationalCodeTextBox.Text);
            Students.Add(student);

            //set properties for textboxes and labels//
            student.FirstName = usersFirstNameTextBox.Text;
            student.LastName = usersLastNameTextBox.Text;
            student.Nationalcode = usersNationalCodeTextBox.Text;

            MessageBox.Show("you are registered");
            //checking role of the user//
            string role = usersRoleTextBox.Text.ToLower().Trim();
            if(role == "student")
            {
                
                student.UserRole = "Student";
                StudentForm StudentForm = new StudentForm(usersFirstNameTextBox.Text,usersLastNameTextBox.Text, usersNationalCodeTextBox.Text);
                StudentForm.Show(); //student form will open//

            }
            else if (role == "master")
            {
                
                student.UserRole = "master";
                MasterForm MasterForm = new MasterForm(usersFirstNameTextBox.Text, usersLastNameTextBox.Text, usersNationalCodeTextBox.Text);
                MasterForm.Show(); // master form will open//
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void studentRoleCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void masterRolecheckBox_CheckedChanged(object sender, EventArgs e)
        {


        }
    }
}
