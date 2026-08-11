using System;
using System.Data.SqlClient;

namespace DVLD_DataAccess
{
    internal class clsMethodHelper
    {

        public static string ConvertReaderIntoString(SqlDataReader reader, string columnName)
        {
            int index = reader.GetOrdinal(columnName);
            if(!reader.IsDBNull(index))
            {
                return reader.GetString(index);
            }
            return string.Empty;
        }

    }
}
