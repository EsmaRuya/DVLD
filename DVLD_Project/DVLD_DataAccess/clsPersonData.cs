using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    internal class clsPersonData
    {
        static public bool IsPersonExist(int personID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELECT found=1 FROM People WHERE PersonId = @personID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex) { isFound = false; }
            finally { connection.Close(); }
            return isFound;
        }

        static public bool IsPersonExist(string nationalNumber)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELECT Found=1 FROM People WHERE NationalNo = @nationalNumber";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nationalNumber", nationalNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                isFound = reader.HasRows;
                reader.Close();
            }
            catch (Exception ex) { isFound = false; }
            finally { connection.Close(); }
            return isFound;
        }

         public static bool GetPersonInfoById(int personID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref string nationalNumber, ref DateTime dateOfBirth, ref short gender, ref string phoneNumber, ref string email, ref int countryID, ref string address, ref string imagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELECT * FROM People WHERE PersonId = @personID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    firstName = (string)reader["FirstName"];
                    secondName = (string)reader["SecondName"];
                    if (reader["ThirdName"] != DBNull.Value)
                        thirdName = (string)reader["ThirdName"];
                    else
                        thirdName = "";
                    lastName = (string)reader["LastName"];
                    nationalNumber = (string)reader["NationalNo"];
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    gender = (short)reader["Gender"];
                    phoneNumber = (string)reader["Phone"];
                    if (reader["Email"] != DBNull.Value)
                    { email = (string)reader["Email"]; }
                    else
                    { email = ""; }
                    countryID = (int)reader["NationalityCountryId"];
                    address = (string)reader["Address"];
                    if (reader["ImagePath"] != DBNull.Value)
                        imagePath = (string)reader["ImagePath"];
                    else
                        imagePath = "";
                }
                else
                    isFound = false;
                
                connection.Close();
            }
            catch(Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool GetPersonInfoByNationalNo(string nationalNumber, ref int personID, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref DateTime dateOfBirth, ref short gender, ref string phoneNumber, ref string email, ref int countryID, ref string address, ref string imagePath)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT * FROM People WHERE NationalNo = @nationalNumber";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@nationalNumber", nationalNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    firstName = clsMethodHelper.ConvertReaderIntoString(reader, "FirstName");
                    secondName = clsMethodHelper.ConvertReaderIntoString(reader, "SecondName");
                    thirdName = clsMethodHelper.ConvertReaderIntoString(reader, "ThirdName");
                    lastName = clsMethodHelper.ConvertReaderIntoString(reader, "LastName");
                    dateOfBirth = (DateTime)reader["DateOfBirth"];
                    gender = (short)reader["Gender"];
                    address = clsMethodHelper.ConvertReaderIntoString(reader, "Address");
                    phoneNumber = clsMethodHelper.ConvertReaderIntoString(reader, "Phone");
                    email = clsMethodHelper.ConvertReaderIntoString(reader, "Email");
                    countryID = (int)reader["NationalityCountryId"];
                    imagePath = clsMethodHelper.ConvertReaderIntoString(reader, "ImagePath");
                }
                else
                    isFound = false;

                connection.Close();
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    
        public static int AddNewPerson(string firstName, string secondName, string thirdName, string lastName, string nationalNumber, DateTime dateOfBirth, short gender, string phoneNumber, string email, int countryID, string address, string imagePath)
        {
            int personID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"INSERT INTO People
                            (FirstName, SecondName,ThirdName, LastName, NationalNo, DateOfBirth, Gender, Address, Phone, Email, NationalityCountryId, ImagePath)
                            VALUES (@firstName, @secondName, @thirdName, @lastName, @nationalNumber, @dateOfBirth, @gender, @address, @phoneNumber, @email, @countryID, @imagePath)
                              SELECT SCOPE_IDENTITY();";
           
            SqlCommand cmd = new SqlCommand(query, connection);
           
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@SsecondName", secondName);
            if (thirdName != "" && thirdName != null)
                cmd.Parameters.AddWithValue("@thirdName", thirdName);
            else
                cmd.Parameters.AddWithValue("@thirdName", DBNull.Value);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@nationalNumber", nationalNumber);
            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            if (email != "" && email != null)
                cmd.Parameters.AddWithValue("@email", email);
            else
                cmd.Parameters.AddWithValue("@email", DBNull.Value);

            cmd.Parameters.AddWithValue("@countryID", countryID);
            if (imagePath != "" && imagePath != null)
                cmd.Parameters.AddWithValue("@imagePath", imagePath);
            else
                cmd.Parameters.AddWithValue("@imagePath", DBNull.Value);

            try
            {
                connection.Open();

                object result = cmd.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    personID = insertedID;
                }

                connection.Close();
            }
           
            catch (Exception ex) { personID = -1; }
            
            finally { connection.Close(); }
            
            return personID;
        }

        public static bool UpdatePerson(int personID,  string firstName, string secondName, string thirdName, string lastName, string nationalNumber, DateTime dateOfBirth, short gender, string phoneNumber, string email, int countryID, string address, string imagePath)
        {
            bool isUpdated = false;
            int rowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"UPDATE People
                             SET FirstName = @firstName,
                                 SecondName = @secondName,
                                 ThirdName = @thirdName,
                                 LastName = @lastName,
                                 NationalNo = @nationalNumber,
                                 DateOfBirth = @dateOfBirth,
                                 Gender = @gender,
                                 Address = @address,
                                 Phone = @phoneNumber,
                                 Email = @email,
                                 NationalityCountryId = @countryID,
                                 ImagePath = @imagePath
                                 WHERE  PersonId = @personID";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@personID", personID);
            cmd.Parameters.AddWithValue("@firstName", firstName);
            cmd.Parameters.AddWithValue("@SsecondName", secondName);
            if (thirdName != "" && thirdName != null)
                cmd.Parameters.AddWithValue("@thirdName", thirdName);
            else
                cmd.Parameters.AddWithValue("@thirdName", DBNull.Value);
            cmd.Parameters.AddWithValue("@lastName", lastName);
            cmd.Parameters.AddWithValue("@nationalNumber", nationalNumber);
            cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            if (email != "" && email != null)
                cmd.Parameters.AddWithValue("@email", email);
            else
                cmd.Parameters.AddWithValue("@email", DBNull.Value);

            cmd.Parameters.AddWithValue("@countryID", countryID);
            if (imagePath != "" && imagePath != null)
                cmd.Parameters.AddWithValue("@imagePath", imagePath);
            else
                cmd.Parameters.AddWithValue("@imagePath", DBNull.Value);

            try
            {
                connection.Open();

                rowsEffected = cmd.ExecuteNonQuery();
                if(rowsEffected > 0)
                {
                    isUpdated = true;
                }
                connection.Close();
            }

            catch (Exception ex) { isUpdated = false; }

            finally { connection.Close(); }

            return isUpdated;
        }

        public static bool DeletePerson(int personID)
        {
            bool isDeleted = false;
            int rowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "DELETE FROM People WHERE PersonId = @personID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();

                rowsEffected = cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch(Exception ex) { isDeleted = false; }

            finally { connection.Close(); }

            // return isDeleted;
            return (rowsEffected > 0);
        }

        public static DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            
            string query = @"SELECT People.PersonId,
                                    People.FirstName,
                                    People.SecondName,
                                    People.ThirdName,
                                    People.LastName,
                                    People.NationalNo,
                                    People.DateOfBirth,
                                    People.Gender,
                                        CASE WHEN People.Gender = 0
                                            THEN 'Male' ELSE 'Female'
                                        END AS Gender,
                                    People.Address,
                                    People.Phone,
                                    People.Email,
                                    People.NationalityCountryId,
                                    Countries.CountryName,
                                    People.ImagePath
                             FROM People
                             INNER JOIN Countries ON People.NationalityCountryId = Countries.CountryId
                             ORDER BY People.FirstName"; 

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();  
                SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex) { }

            finally { connection.Close(); }

            return dt;
        }
    }
}
