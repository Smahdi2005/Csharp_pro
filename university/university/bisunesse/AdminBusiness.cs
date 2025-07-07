using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using university.Entities;
using university.interfaces;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
internal class AdminBusiness : IBaseBusiness<Admin>, IAdminBusiness<Admin>

{
    //const string connectionString = "Data Source=.;Initial Catalog=BookShop;Integrated Security=True;";
    string connectionString = ConfigurationManager.ConnectionStrings["universityDb"].ToString();


    public AdminBusiness()
    {
    }

    public bool Add(Admin item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            bool isAffected = false;
            try
            {
                connection.Open();
                string tableName = "[Admin]";

                // Create a SQL command to insert a new person record
                string query = $"INSERT INTO {tableName} (FirstName, LastName, UserName , Password ) " +
                               "VALUES (@FirstName, @LastName, @UserName ,@Password)";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the SQL command
                //command.Parameters.AddWithValue("@Id", person.Id);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@UserName", item.UserName);
                command.Parameters.AddWithValue("@Password", item.Password);
                // Execute the insert query
                int rowsAffected = command.ExecuteNonQuery();

                isAffected = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isAffected;
        }
    }
#nullable disable
    public bool  GetDataFromDb(string userName , string password)
    {
        Admin admin = null;
        try
        {
            using (SqlConnection conection = new SqlConnection(connectionString))
            {
                bool IsAffected = false;

                conection.Open();

                string query = @"SELECT Id , UserName  , Password  FROM [Admin] WHERE UserName = @UserName AND Password = @Password";

                using (SqlCommand cmd = new SqlCommand(query, conection))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName.Trim());

                    cmd.Parameters.AddWithValue("@Password", password.Trim());

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

    public bool GetMobileNumberFromDb(string mobileNumber)
    {
        throw new NotImplementedException();
    }
#nullable enable

    public bool Update(Student item)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            bool isAffected = false;
            try
            {
                connection.Open();

                // Create a SQL command to insert a new person record
                string query = "UPDATE dbo.[Admin] " +
                                "SET FirstName = @FirstName, " +
                                    "LastName = @LastName," +
                                    "UserName = @UserName," +
                                    "NationalCode = @Password " +
                                "WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the SQL command
                //command.Parameters.AddWithValue("@Id", person.Id);
                command.Parameters.AddWithValue("@FirstName", item.FirstName);
                command.Parameters.AddWithValue("@LastName", item.LastName);
                command.Parameters.AddWithValue("@PhoneNumber", item.MobileNumber);
                command.Parameters.AddWithValue("@NationalCode", item.NationalCode);
                command.Parameters.AddWithValue("@Id", item.Id);

                // Execute the insert query
                int rowsAffected = command.ExecuteNonQuery();

                isAffected = rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
            return isAffected;
        }
    }

    bool IBaseBusiness<Admin>.Add(Admin item)
    {
        throw new NotImplementedException();
    }

    
    

    bool IAdminBusiness<Admin>.Add(Admin item)
    {
        throw new NotImplementedException();
    }

    bool IAdminBusiness<Admin>.Delete(Admin item)
    {
        throw new NotImplementedException();
    }

    Student IBaseBusiness<Admin>.GetDataFromDb(string userName, string password)
    {
        throw new NotImplementedException();
    }

    bool IBaseBusiness<Admin>.update(Admin item)
    {
        throw new NotImplementedException();
    }

    
    bool IAdminBusiness<Admin>.Update(Admin item)
    {
        throw new NotImplementedException();
    }
}