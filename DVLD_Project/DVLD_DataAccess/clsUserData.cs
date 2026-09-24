using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsUserData
    {
        public static bool isUserExist(int UserId)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT found=1 FROM Users WHERE UserId = @UserId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserId", UserId);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }

            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return isFound;

        }
        public static bool isUserExist(string UserName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT found=1 FROM Users WHERE UserName = @UserName";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }

            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return isFound;

        }
        public static bool isUserExistForPersonId(int PersonId)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT found=1 FROM Users WHERE PersonId = @PersonId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonId", PersonId);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }

            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return isFound;

        }

        public static bool GetUserInfoByUserId(int UserId, ref int PersonId, ref string UserName, ref string PassWord, ref bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELET * FROM Users
                             WHERE UserId = @UserId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserId", UserId);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    PersonId = (int)reader["PersonId"];
                    UserName = clsMethodHelper.ConvertReaderIntoString(reader, "UserName");
                    PassWord = clsMethodHelper.ConvertReaderIntoString(reader, "PassWord");
                    isActive = (bool)reader["isActive"];
                }
                else isFound = false;

                connection.Close();
            }

            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return isFound;
        }
        public static bool GetUserInfoByPersonId(int PersonId, ref int UserId, ref string UserName, ref string PassWord, ref bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELET * FROM Users
                             WHERE PersonId = @PersonId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@PersonId", PersonId);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserId = (int)reader["UserId"];
                    UserName = clsMethodHelper.ConvertReaderIntoString(reader, "UserName");
                    PassWord = clsMethodHelper.ConvertReaderIntoString(reader, "PassWord");
                    isActive = (bool)reader["isActive"];
                }
                else isFound = false;
                
                connection.Close();
            }

            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return isFound;
        }

        public static bool GetUserInfoByUsernamePassword(string UserName, string PassWord, ref int UserId, ref int PersonId, ref bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELET * FROM Users
                             WHERE UserName = @UserName AND PassWord = @PassWord";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@PassWord", PassWord);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserId = (int)reader["UserId"];
                    PersonId = (int)reader["PersonId"];
                    isActive = (bool)reader["isActive"];
                }
                else isFound = false;

                connection.Close();
            }

            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return isFound;
        }

        public static int AddNewUser(int PersonId, string UserName, string PassWord, bool isActive)
        {
            int UserId = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"INSERT INTO Users
                             (PersonId, UserName, PassWord, isActive)
                             VALUES (@PersonId, @UserName, @PassWord, @isActive);
                             SELECT SCOPE_IDENTITY();";
                               
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonId", PersonId);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@PassWord", PassWord);
            cmd.Parameters.AddWithValue("@isActive", isActive);

            try
            {
                connection.Open();
                
                object retult = cmd.ExecuteScalar();
                if (retult != null && int.TryParse(retult.ToString(), out int insrtedID)) UserId = insrtedID;

                connection.Close();
            }

            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return UserId;
        }

        public static bool UpdateUser(int UserId, int PersonId, string UserName, string PassWord, bool isActive)
        {
            int rowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"UPDATE Users
                             SET PersonId = @PersonId,
                                 UserName = @UserName,
                                 PassWord = @PassWord,
                                 isActive = @isActive
                                 WHERE UserId = @UserId";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PersonId", PersonId);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@PassWord", PassWord);
            cmd.Parameters.AddWithValue("@isActive", isActive);
            cmd.Parameters.AddWithValue("@UserId", UserId);

            try
            {
                connection.Open();
                rowsEffected = cmd.ExecuteNonQuery();
            }

            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return (rowsEffected > 0);
        }

        public static bool DeleteUser(int UserId)
        {
            int rowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "DELETE FROM Users WHERE UserId = @UserId";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@UserId", UserId);

            try
            {
                connection.Open();
                rowsEffected = cmd.ExecuteNonQuery();
            }

            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return (rowsEffected > 0);
        }

        public static bool ChangePassword(int UserId, string NewPassword)
        {
            int rowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"UPDATE Users
                             SET PassWord = @NewPassword,
                                 WHERE UserId = @UserId";
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@PassWord", NewPassword);
            cmd.Parameters.AddWithValue("@UserId", UserId);

            try
            {
                connection.Open();
                rowsEffected = cmd.ExecuteNonQuery();
            }

            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return (rowsEffected > 0);
        }
        
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELET Users.UserId,
                                   Users.PersonId,
                                   FullName = People.FirstName + ' ' + People.SecondName + ' ' +  ISNULL(People.ThirdName, '') + ' ' + People.LastName,
                                   Users.UserName,
                                   Users.isActive
                             FROM Users 
                             INNER JOIN People ON Users.PersonId = People.PersonId";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) dt.Load(reader);
                reader.Close();
            }

            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return dt;
        }
    }
}
