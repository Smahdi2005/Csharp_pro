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
    public bool ShowInfo(string firstName, string lastName, string nationalCode, string studentCode)
    {
        Student student = null;
        try
        {
            using (SqlConnection conection = new SqlConnection(connectionString))
            {
                bool IsAffected = false;

                conection.Open();

                string query = @"SELECT Id , FirstName , LastName , NationalCode , StudentCode  FROM [Student] WHERE FirstName=@FirstName AND LastName=@LastName AND StudentCode = @StudentCode AND NationalCode = @NationalCode";

                using (SqlCommand cmd = new SqlCommand(query, conection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", firstName.Trim());

                    cmd.Parameters.AddWithValue("@LastName", lastName.Trim());
                    
                    cmd.Parameters.AddWithValue("@StudentCode", studentCode.Trim());

                    cmd.Parameters.AddWithValue("@NationalCode", nationalCode.Trim());

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        catch (Exception ex)
        {
            MessageBox.Show($"Error : {ex.Message}");
            return false;

        }

    }

    public bool GetDataFromDb(string userName, string password)
    {
        Student student = null;
        try
        {
            using (SqlConnection conection = new SqlConnection(connectionString))
            {
                bool IsAffected = false;

                conection.Open();

                string query = @"SELECT Id , StudentCode  , NationalCode  FROM [Student] WHERE StudentCode = @StudentCode AND NationalCode = @NationalCode";

                using (SqlCommand cmd = new SqlCommand(query, conection))
                {
                    cmd.Parameters.AddWithValue("@StudentCode", userName.Trim());

                    cmd.Parameters.AddWithValue("@NationalCode", password.Trim());

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }


        catch (Exception ex)
        {
            MessageBox.Show($"Error : {ex.Message}");
            return false;

        }

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

