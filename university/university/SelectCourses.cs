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

namespace university
{
    public partial class SelectCourses : Form
    {
        public SelectCourses()
        {
            InitializeComponent();
            majorGroupComboBox.Items.AddRange(new string[] { "Engineering", "Humanities", "Science" });
            courseTypeComboBox.Items.AddRange(new string[] { "general course", "specialized course" });

            majorGroupComboBox.SelectedIndex = -1;
            courseTypeComboBox.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void searchCurseButton_Click(object sender, EventArgs e)
        {
            if (majorGroupComboBox.SelectedItem == null || courseTypeComboBox.SelectedItem == null)
            {
                MessageBox.Show("please choose valid parameters");
                return;
            }

            string selectedMajorGroup = majorGroupComboBox.SelectedItem.ToString();
            string selectedCourseType = courseTypeComboBox.SelectedItem.ToString();

            CourseBusiness business = new CourseBusiness();
            List<Course> result = business.SearchCourse(selectedCourseType, selectedMajorGroup);

            coursesDataGridView.AutoGenerateColumns = true;
            coursesDataGridView.DataSource = result;
        }
    }
}
