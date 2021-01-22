using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Korelskiy.WSRProject.Models;

namespace Korelskiy.WSRProject.Infrastructure
{
    public class DbProcessor : IDbProccessor
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Session1_Korelskiy;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private SqlConnection connection;
        private SqlDataReader dr;

        public DbProcessor()
        {
            connection = new SqlConnection(connectionString);
        }
        
        public void ChangeUserRole(string emailAddress, int roleId)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand com = new SqlCommand($"UPDATE Users SET RoleId=@RoleId WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("RoleId", roleId);
                com.Parameters.AddWithValue("Email", emailAddress);
                com.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void AddUserActivity(UserActivity activity)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand com = new SqlCommand($"INSERT INTO UserTimeInSystem" +
                    $"(UserId, LoginTime, LogoutTime, FullTimeInSystem, LogoutReason)" +
                    $" VALUES(@UserId, @LoginTime, @LogoutTime, @FullTimeInSystem, @LogoutReason) ", connection);

                com.Parameters.AddWithValue("UserId", activity.UserId);
                com.Parameters.AddWithValue("LoginTime", activity.LoginTime);
                com.Parameters.AddWithValue("LogoutTime", activity.LogoutTime);
                com.Parameters.AddWithValue("FullTimeInSystem", activity.TimeSpentOnSystem);
                com.Parameters.AddWithValue("LogoutReason", activity.LogoutReason);

                com.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void AddUser(User user)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
               
                SqlCommand com = new SqlCommand($"INSERT INTO Users" +
                    $"(RoleId, Email, Password, FirstName, LastName, OfficeID, Birthdate, Active, FullTimeInSystem, NumberOfCrashes)" +
                    $" VALUES(@RoleId, @Email, @Password, @FirstName, @LastName, @OfficeID, @Birthdate, @Active, @FullTimeInSystem, @NumberOfCrashes) ", connection);

                com.Parameters.AddWithValue("RoleId", 2);
                com.Parameters.AddWithValue("Email", user.EmailAddress);
                com.Parameters.AddWithValue("Password", GetHash(user.Password));
                com.Parameters.AddWithValue("FirstName", user.Name);
                com.Parameters.AddWithValue("LastName", user.LastName);
                int officeId = User.Offices.FirstOrDefault(x => x.Value == user.Office).Key;
                com.Parameters.AddWithValue("OfficeID", officeId);
                com.Parameters.AddWithValue("Birthdate", user.Birthday);
                com.Parameters.AddWithValue("Active", 1);
                com.Parameters.AddWithValue("FullTimeInSystem", user.TimeSpentOnSystem);
                com.Parameters.AddWithValue("NumberOfCrashes", 0);
                com.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void ChangeActiveStatus(int status, string email)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"UPDATE Users SET Active=@Active WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("Active", status);
                com.Parameters.AddWithValue("Email", email);
                com.ExecuteNonQuery();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<UserActivity> GetUserActivities()
        {
            List<UserActivity> activities = new List<UserActivity>();

            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"SELECT * FROM UserTimeInSystem", connection);

                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    int userId = Convert.ToInt32(dr["UserId"]);
                    string loginTime = dr["LoginTime"].ToString();
                    string logoutTime = dr["LogoutTime"].ToString();
                    string timeSpentOnSystem = dr["FullTimeInSystem"].ToString();
                    string logoutReason = dr["LogoutReason"].ToString();

                    UserActivity activity = new UserActivity();
                    activity.UserId = userId;
                    activity.LoginTime = TimeSpan.Parse(loginTime);
                    activity.LogoutTime = TimeSpan.Parse(logoutTime);
                    activity.TimeSpentOnSystem = TimeSpan.Parse(timeSpentOnSystem);
                    activity.LogoutReason = logoutReason;

                    activities.Add(activity);
                }

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return activities;
        }

        public void IncrementCrashes(string emailAddress)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand com = new SqlCommand($"SELECT NumberOfCrashes FROM Users WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("Email", emailAddress);
                int crashes = Convert.ToInt32(com.ExecuteScalar());

                crashes++;

                SqlCommand cmd = new SqlCommand($"UPDATE Users SET NumberOfCrashes=@NumberOfCrashes WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("NumberOfCrashes", crashes);
                com.Parameters.AddWithValue("Email", emailAddress);
                com.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateUserTimeInSystem(TimeSpan time, string email)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"UPDATE Users SET FullTimeInSystem=@FullTimeInSystem WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("FullTimeInSystem", time);
                com.Parameters.AddWithValue("Email", email);
                com.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"SELECT * FROM Users", connection);

                dr = com.ExecuteReader();

                while (dr.Read())
                {
                    int id = Convert.ToInt32(dr["ID"]);
                    int active = Convert.ToInt32(dr["Active"]);
                    int roleId = Convert.ToInt32(dr["RoleId"]);
                    string timeInSystem = dr["FullTimeInSystem"].ToString();
                    int numOfCrashes = Convert.ToInt32(dr["NumberOfCrashes"]);

                    User user = new User(active, roleId);

                    user.Id = id;

                    user.Name = dr["FirstName"].ToString();

                    user.LastName = dr["LastName"].ToString();

                    int birthday = Convert.ToDateTime(dr["Birthdate"]).Year;
                    user.Age = DateTime.Now.Year - birthday;

                    
                    user.UserRole = roleId == 1 ? "Администратор" : "Сотрудник";

                    user.EmailAddress = dr["Email"].ToString();

                    int officeId = Convert.ToInt32(dr["OfficeID"]);
                    user.Office = User.Offices.FirstOrDefault(x => x.Key == officeId).Value;

                    user.Active = active == 0 ? false : true;

                    if (timeInSystem != "")
                    {
                        user.TimeSpentOnSystem = TimeSpan.Parse(timeInSystem);
                    }
                    

                    user.NumberOfCrashes = numOfCrashes;

                    users.Add(user);
                }

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return users;
        }

        bool IDbProccessor.Login(string userEmail, string userPassword)
        {
            string password = GetHash(userPassword);
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"SELECT count(*) FROM Users WHERE Email=@Email AND Password=@Password", connection);
                com.Parameters.AddWithValue("Email", userEmail);
                com.Parameters.AddWithValue("Password", password);
                int i = Convert.ToInt32(com.ExecuteScalar());
                if (i == 0)
                {
                    MessageBox.Show("Пользователь не найден");
                    return false;
                }
                if (i == 1)
                {
                    if (CheckActiveUser(userEmail))
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Пользователь заблокирован администратором.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public int GetUserRole(string userEmail)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                SqlCommand com = new SqlCommand($"SELECT RoleId FROM Users WHERE Email=@Email", connection);
                com.Parameters.AddWithValue("Email", userEmail);
                int i = Convert.ToInt32(com.ExecuteScalar());
                return i;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return -1;
        }

        public bool CheckActiveUser(string userEmail)
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand com = new SqlCommand($"SELECT Active FROM Users WHERE Email=@Email", connection);
            com.Parameters.AddWithValue("Email", userEmail);
            int active = Convert.ToInt32(com.ExecuteScalar());
            if (active == 1)
            {
                return true;
            }
            return false;
        }

        private string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.ASCII.GetBytes(input));
            string pass = Convert.ToBase64String(hash);

            return pass;
        }
    }
}
