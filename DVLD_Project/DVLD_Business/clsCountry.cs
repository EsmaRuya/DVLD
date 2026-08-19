using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsCountry
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountry()
        {
            this.CountryID = -1;
            this.CountryName = "";
        }

        private clsCountry(int CountryID, string countryName)
        {
            this.CountryID = CountryID;
            this.CountryName = countryName;
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryData.GetAllCountryies();
        }

        public static clsCountry Find(int CountryID)
        {
            string CountryName = "";

            if (clsCountryData.GetCountryInfoByID(CountryID, ref CountryName))

                return new clsCountry(CountryID, CountryName);
            else
                return null;

        }

        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;

            if (clsCountryData.GetCountryInfoByName(ref CountryID, CountryName))

                return new clsCountry(CountryID, CountryName);
            else
                return null;

        }
    }
}
