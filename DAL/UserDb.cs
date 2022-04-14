using DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserDb : IUserDb
    {

        private string connectionString = null;
        public UserDb()
        {
            connectionString = ConfigurationManager.ConnectionStrings["ITServiceProjectBeaudDeBlasiConnectionString"].ConnectionString;
        }



        public User GetAmountByUserId(int userId)
        {
            User result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM UserAmount where UserId = @userId";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new User();

                            result.userAmount = (int)dr["UserAmount"];
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }
    }
}
