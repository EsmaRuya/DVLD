using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    public class clsApllicationTypeData
    {
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELECT * FROM ApplicationTypes
                            ORDER BY ApplicationTypeTitle";
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

        public static bool GetApplicationTypeByID(int ApplicationTypesId, ref string ApplicationTitle, ref float ApplicationFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"SELECT * FROM ApplicationTypes   
                             WHERE ApplicationTypesId = @ApplicationTypesId";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationTypesId", ApplicationTypesId);

            try
            {
                connection.Open();
               SqlDataReader reader = cmd.ExecuteReader();
                if(reader.Read())
                {
                    isFound = true;

                    ApplicationTitle = clsMethodHelper.ConvertReaderIntoString(reader,"ApplicationTitle");
                    ApplicationFees = (float)reader["ApplicationFees"];
                }
                reader.Close();
            }
            catch (Exception ex) { throw; }

            finally { connection.Close(); }

            return isFound;
        }

        public static bool UpdateApplicationType(int ApplicationTypesId, string ApplicationTitle, float ApplicationFees)
        {
            int rowsEffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"UPDATE ApplicationTypes
                             SET ApplicationTitle = @ApplicationTitle,
                                 ApplicationFees = @ApplicationFees   
                             WHERE ApplicationTypesId = @ApplicationTypesId";
            
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@ApplicationTypesId", ApplicationTypesId);
            cmd.Parameters.AddWithValue("@ApplicationTitle", ApplicationTitle);
            cmd.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);

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
