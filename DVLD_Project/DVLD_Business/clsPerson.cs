using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode;

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
           // Default Constructor
            
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

            Mode = enMode.AddNew;
        }

        private clsPerson(int PersonId, string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth, short Gender, string Address, string Phone, string Email, int CountryId, string ImagePath)
        {
            // Parameterized Constructor

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

            Mode = enMode.Update;

        }

        // Methods
        private bool _AddNewPerson()
        {
            PersonID = clsPersonData.AddNewPerson(FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth, Gender, Phone, Email, CountryID, Address, ImagePath);
            return (PersonID != -1);
        }
       
        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth, Gender, Phone, Email, CountryID, Address, ImagePath);
        }
        public static DataTable GetAllPeople()
        {
            return clsPersonData.GetAllPeople();
        }

        public static bool isPersonExist(int personId)
        {
            return clsPersonData.IsPersonExist(personId);
        }
     
        public static bool isPersonExist(string nationalNo)
        {
            return clsPersonData.IsPersonExist(nationalNo);
        }

        public static clsPerson Find(int PersonId)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gender = -1;
            int CountryId = -1;

            bool isFound = clsPersonData.GetPersonInfoById(PersonId, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref NationalNo, ref DateOfBirth, ref Gender, ref Phone, ref Email, ref CountryId, ref Address, ref ImagePath);

            if (isFound) return new clsPerson(PersonId, FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth, Gender, Address, Phone, Email, CountryId, ImagePath);
            else return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:
                    return _UpdatePerson();
            }       
              
            return false;
        }

        public static bool DeletePerson(int PersonId)
        {
            return clsPersonData.DeletePerson(PersonId);
        }
    
    }
}
