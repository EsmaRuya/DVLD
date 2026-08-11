using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsCountryData
    {
        
        public static bool GetCountryInfoByID(int countryID, ref string countyName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT * FROM Countries WHERE CountryID = @countryID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@countryID", countryID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;
                    countyName = clsMethodHelper.ConvertReaderIntoString(reader, "CountryName");
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex) { isFound = false; }

            finally { connection.Close(); }

            return isFound;
        }

        public static bool GetCountryInfoByName(ref int countryID,  string countyName)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT * FROM Countries WHERE CountryName = @countyName";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@countyName", countyName);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;
                    countryID = (int)reader["CountryID"];
                }
                else
                {
                    isFound = false;
                }

                reader.Close();
            }
            catch (Exception ex) { isFound = false; }

            finally { connection.Close(); }

            return isFound;
        }

        public static DataTable GetAllCountryies()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "SELECT * FROM Countries";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception ex) { }

            finally { connection.Close(); }
            
            return dt;
        }
    }
}
