using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsTestTypeData
    {
        public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELECT * FROM TestTypes
                            ORDER BY TestTypeId";
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

        public static bool GetTestTypeByID(int TestTypeId, ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELECT * FROM TestTypes   
                             WHERE TestTypeId = @TestTypeId";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestTypeId", TestTypeId);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    TestTypeTitle = clsMethodHelper.ConvertReaderIntoString(reader, "TestTypeTitle");
                    TestTypeDescription = clsMethodHelper.ConvertReaderIntoString(reader, "TestTypeDescription");
                    TestTypeFees = (decimal)reader["TestTypeFees"];
                }
                reader.Close();
            }
            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return isFound;
        }

        public static bool UpdateTestType(int TestTypeId, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            int rowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"UPDATE TestTypes
                             SET TestTypeTitle = @TestTypeTitle,
                                 TestTypeDescription = @TestTypeDescription,   
                                 TestTypeFees = @TestTypeFees   
                             WHERE TestTypeId = @TestTypeId";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestTypeId", TestTypeId);
            cmd.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            cmd.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);
            cmd.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);

            try
            {
                connection.Open();
                rowsEffected = cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return (rowsEffected > 0);
        }

    }
}
