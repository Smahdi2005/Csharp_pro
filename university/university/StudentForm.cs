using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace university
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void selectCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectCourses selectCourse = new SelectCourses();
            selectCourse.Show();
        }

        private void addCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourses addCourse = new AddCourses();
            addCourse.Show();
        }

        private void semesterStatueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SemesterStatue semesterStatue = new SemesterStatue();
            semesterStatue.Show();
        }
    }
}
