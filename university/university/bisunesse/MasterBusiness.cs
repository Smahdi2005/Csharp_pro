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
    internal class MasterBusiness : IBaseBusiness<Master>
    {
        string connectionString = ConfigurationManager.ConnectionStrings["universityDb"].ToString();

        public bool Add(Master item)
        {
            throw new NotImplementedException();
        }

        public bool GetDataFromDb(string userName, string password)
        {
            Master master = null;
            try
            {
                using (SqlConnection conection = new SqlConnection(connectionString))
                {
                    bool IsAffected = false;

                    conection.Open();

                    string query = @"SELECT Id , UserName  , Password  FROM [Master] WHERE UserName = @UserName AND Password = @Password";

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

        public bool update(Master item)
        {
            throw new NotImplementedException();
        }

        Student IBaseBusiness<Master>.GetDataFromDb(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}
