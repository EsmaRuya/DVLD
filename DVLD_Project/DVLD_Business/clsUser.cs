using System;
using System.Data;
using DVLD_DataAccess;

namespace DVLD_Business
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1};
        public enMode Mode;

        public clsPerson PersonInfo; // Composition

        public int personID {  get; set; }
        public int UserID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool isActive { get; set; }

        public clsUser()
        {
           // this.personID = -1; 
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.isActive = false;

            Mode = enMode.AddNew;
        }

        private clsUser(int PersonId, int UserId, string UserName, string PassWord, bool isActive)
        {
            this.PersonInfo = clsPerson.Find(PersonId);
            this.personID = PersonId;
            this.UserID = UserId;
            this.UserName = UserName;
            this.Password = PassWord;
            this.isActive = isActive;

            Mode = enMode.Update;
        }

        private bool _AddNewUser()
        {
            UserID = clsUserData.AddNewUser(personID, UserName, Password, isActive);
            return (UserID != -1);
        }

        private bool _UpdateUser()
        {
           return clsUserData.UpdateUser(UserID, personID, UserName, Password, isActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else return false;

                case enMode.Update:
                    return _UpdateUser();
            }

            return false;
        }

        public static bool isUserExist(int UserId)
        {
            return clsUserData.isUserExist(UserId);
        }
      
        public static bool isUserExist(string UserName)
        {
            return clsUserData.isUserExist(UserName);
        }

        public static bool isUserExistForPersinId(int PersonId)
        {
            return clsUserData.isUserExistForPersonId(PersonId);
        }

        public static bool DeleteUser(int UserId)
        {
            return clsUserData.DeleteUser(UserId);
        }

        public static bool ChangePassword(int UserId, string NewPassword)
        {
            return clsUserData.ChangePassword(UserId, NewPassword);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

       public static clsUser Find(int UserId)
       {
            int PersonId = -1;
            string UserName = "", PassWord = ""; 
            bool isActive = false;

            if (clsUserData.GetUserInfoByUserId(UserId, ref PersonId, ref UserName, ref PassWord, ref isActive))
                return new clsUser(PersonId ,UserId, UserName, PassWord, isActive);

            return null;
       }
       
        public static clsUser Find(string UserName, string PassWord)
       {
            int PersonId = -1, UserId = -1;
            bool isActive = false;

            if (clsUserData.GetUserInfoByUsernamePassword(UserName, PassWord, ref UserId, ref PersonId, ref isActive))
                return new clsUser(PersonId ,UserId, UserName, PassWord, isActive);

            else return null;
       }

       public static clsUser FindByPersonId(int PersonId)
       {
            int UserId = -1;
            string UserName = "", PassWord = ""; 
            bool isActive = false;

            if (clsUserData.GetUserInfoByPersonId(PersonId, ref UserId, ref UserName, ref PassWord, ref isActive))
                return new clsUser(PersonId ,UserId, UserName, PassWord, isActive);

            return null;
       }
    }
}
