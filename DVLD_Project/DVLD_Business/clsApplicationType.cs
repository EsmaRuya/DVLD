using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsApplicationType
    {
        public int ApplicationTypesId { set; get; }
        public string ApplicationTitle { set; get; }
        public decimal ApplicationFees { set; get; }

        clsApplicationType()
        {
            ApplicationTypesId = -1;
            ApplicationTitle = "";
            ApplicationFees = -1;
        }

        clsApplicationType(int ApplicationTypesId, string ApplicationTitle, decimal ApplicationFees)
        {
            this.ApplicationTypesId = ApplicationTypesId;
            this.ApplicationTitle = ApplicationTitle;
            this.ApplicationFees = ApplicationFees;
        }

        private bool _UpdateApplicationType()
        {
            return clsApplicationTypeData.UpdateApplicationType(ApplicationTypesId, ApplicationTitle, ApplicationFees );
        }

        public static clsApplicationType Find(int AppTypeID)
        {
            string AppTypeName = "";
            decimal AppTypeFee = -1;
            if (clsApplicationTypeData.GetApplicationTypeByID(AppTypeID, ref AppTypeName, ref AppTypeFee))
                return new clsApplicationType(AppTypeID, AppTypeName, AppTypeFee);
            else
                return null;
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApplicationTypeData.GetAllApplicationTypes();
        }

        public bool Save()
        {
            //switch(Mode)
            //{
            // case enMode.AddNew:
            // if(_AddNewApplicationType())
            // {
            // Mode = enMode.Update;
            // return true;
            // }
            // case enMode.Update:
            return _UpdateApplicationType();
            //}

         //   return false;
        }

    }
}
