using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPerson
    {
        // Fields
        public clsCountry CountryInfo;

        // Properties: Getters & Setters 
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName 
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public string NationalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gender  { get; set; }
        public string Address  { get; set; }
        public string Phone  { get; set; }
        public string Email  { get; set; }
        public int CountryID  { get; set; }
        
        private string _ImagePath;
        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        // Constructors
        public clsPerson()
        {
            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.NationalNo = "";
            this.DateOfBirth = DateTime.Now;
            this.Gender = -1;
            this.Address = "";
            this.Phone = "";
            this.Email = "";
            this.CountryID = -1;
            this.ImagePath = "";
        }

        private clsPerson(int PersonId, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth, short Gender, string Address, string Phone, string Email, int CountryId, string ImagePath)
        {
            this.PersonID = PersonId;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.NationalNo = NationalNo;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.CountryID = CountryId;
            this.CountryInfo = clsCountry.Find(CountryId);
            this.ImagePath = ImagePath;

        }

        // Methods
        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

    }
}
