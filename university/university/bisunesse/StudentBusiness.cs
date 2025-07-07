using Microsoft.Data.SqlClient;
using System.Configuration;
using university.Entities;
using university.interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace university.bisunesse;

internal class StudentBusiness : IBaseBusiness<Student> , IStudentBusiness
{
    string connectionString = ConfigurationManager.ConnectionStrings["universityDb"].ToString();

    public bool Add(Student item)
    {
        throw new NotImplementedException();
    }

#nullable disable
    public Student ShowInfo(int id)
    {
        Student student = null;
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            string query = "SELECT s.Id , s.FirstName , s.LastName , s.NationalCode , s.StudentCode , m.Major FROM Student s JOIN Major m ON s.MajorId = m.Id WHERE s.Id = @Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                student = new Student()
                {
                    Id = (int)reader["Id"],
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    NationalCode = reader["NationalCode"].ToString(),
                    StudentCode = reader["StudentCode"].ToString(),
                    MajorName = reader["Major"].ToString()
                };
            }
        }
        return student;
    }
#nullable enable
    public Student GetDataFromDb(string userName, string password)
    {
        Student student = null;
        try
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT    s.Id,    s.FirstName,    s.LastName,   s.NationalCode,    s.StudentCode,    m.Major  FROM Student s INNER JOIN  Major m ON s.MajorId = m.Id  WHERE  s.StudentCode = @StudentCode AND s.NationalCode = @NationalCode";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@StudentCode", userName);
                cmd.Parameters.AddWithValue("@NationalCode", password);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    student = new Student
                    {
                        Id = (int)reader["Id"],
                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        NationalCode = reader["NationalCode"].ToString(),
                        StudentCode = reader["StudentCode"].ToString(),
                        MajorName = reader["Major"].ToString()
                    };
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Eror: " + ex.Message);
        }

        return student;
    }


        public bool update(Student item)
    {
        throw new NotImplementedException();
    }

    public bool ChangePassword(string mobileNumber, string newPassword)
    {
        try
        {
            using (SqlConnection conection = new SqlConnection(connectionString))
            {
                conection.Open();
                string query = "UPDATE Student SET Password = @Password WHERE MoileNumber = @MoileNumber";
                using (SqlCommand cmd = new SqlCommand(query, conection))
                {
                    cmd.Parameters.AddWithValue("Password", newPassword);
                    cmd.Parameters.AddWithValue("MoileNumber", mobileNumber);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error : {ex.Message}");
            return false;
        }
    }


}

