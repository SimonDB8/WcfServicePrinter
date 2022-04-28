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
            connectionString = "Data Source = 153.109.124.35; Initial Catalog = ITServiceProjectBeaudDeBlasi; Persist Security Info = True; User ID = 6231db; Password = Pwd46231.";
        }

        public User AddAmountByUserId(int userId, int amount)

        {
            User result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Users SET UserAmount=@amount WHERE UserId = @userId";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                      
                            if (dr.Read())
                            {
                                result = new User();

                                result.userId = (int)dr["userId"];
                                result.userName = (string)dr["userName"];
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

        public User AddAmountByUsername(string username, int amount)
        {
            User result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Users SET UserAmount=@amount WHERE UserName = @username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@amount", amount);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        if (dr.Read())
                        {
                            result = new User();

                            result.userId = (int)dr["userId"];
                            result.userName = (string)dr["UserName"];
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



        public User GetAmountByUserId(int userId)
        {
            User result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT UserAmount FROM Users where UserId = @userId";
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


        public User getUserById(int userId)
        {
            User result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECt * FROM Users WHERE UserId = @userId;";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@userId", userId);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new User();

                            result.userId = (int)dr["userId"];
                            result.userName = (string)dr["userName"];
                            result.userAmount = (int)dr["UserAmount"];
                        }
                    }
                }
            }catch (Exception e)
            {
                throw e;
            }

            return result;
        }


        public User getUserByUsername(string username)
        {
            User result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECt * FROM Users WHERE UserName = @username;";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@username", username);
                    cn.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            result = new User();

                            result.userId = (int)dr["userId"];
                            result.userName = (string)dr["UserName"];
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



        public User getAmountByUsername(string username)
        {
            User result = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT UserAmount FROM Users where UserName = @username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@username", username);
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
