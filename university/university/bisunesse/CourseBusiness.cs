using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university.Entities;
using university.interfaces;

namespace university.bisunesse
{
    internal class CourseBusiness : ICourseBusiness
    {
        string connectionString = ConfigurationManager.ConnectionStrings["universityDb"].ToString();

        public bool SelectCourse()
        {
            throw new NotImplementedException();

        }
        
        
        public List<Course> SearchCourse(string majorGroup , string courseType)
        {
            
            List<Course> courses = new List<Course>();

            try
            {

                using (SqlConnection conection = new SqlConnection(connectionString))
                {

                    string query = "SELECT * FROM Course WHERE MajorGroup=@MajorGroup AND CourseType=@CourseType";



                    SqlCommand cmd = new SqlCommand(query, conection);
                    cmd.Parameters.AddWithValue("@MajorGroup", majorGroup);
                    cmd.Parameters.AddWithValue("@CourseType", courseType);

                    conection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Course course = new Course()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            MajorGroup = reader["MajorGroup"].ToString(),
                            CourseName = reader["CourseName"].ToString(),
                            CourseType = reader["CourseType"].ToString(),
                            Day = reader["Day"].ToString(),
                            Time = Convert.ToDateTime(reader["Time"]),
                            QuizTime = Convert.ToDateTime(reader["QuizTime"]),
                            Master = Convert.ToInt32(reader["Master"]),
                            ClassCapasity = Convert.ToInt32(reader["ClassCapasity"]),
                        };
                        courses.Add(course);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در دریافت لیست کورس‌ها:\n" + ex.Message);
            }

        return courses;
            
        }
    }

}

