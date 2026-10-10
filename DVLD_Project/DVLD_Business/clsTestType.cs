using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsTestType
    {
        public enum enTestType { VisionTest = 1, 
                                 WrittenTest = 2,
                                 StreetTest = 3};

        public clsTestType.enTestType TestTypeId { set; get; }
        public string TestTypeTitle { set; get; }
        public string TestTypeDescription { set; get; }
        public decimal TestTypeFees { set; get; }

        public clsTestType()
        {
            TestTypeId = clsTestType.enTestType.VisionTest;
            TestTypeTitle = "";
            TestTypeDescription = "";
            TestTypeFees = 0;
        }

        public clsTestType(clsTestType.enTestType TestTypeId, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {
            this.TestTypeId = TestTypeId;
            this.TestTypeTitle = TestTypeTitle;
            this.TestTypeDescription = TestTypeDescription;
            this.TestTypeFees = TestTypeFees;
        }

        private bool _UpdateTestType()
        {
            return clsTestTypeData.UpdateTestType((int)TestTypeId, TestTypeTitle, TestTypeDescription, TestTypeFees);
        }

        public static clsTestType Find(clsTestType.enTestType TestTypeID)
        {
            string TestTypeName = "", TestDescriptionType = "";
            decimal TestTypeFee = 0;

            if (clsTestTypeData.GetTestTypeByID((int)TestTypeID, ref TestTypeName,ref TestDescriptionType,ref TestTypeFee))
                return new clsTestType(TestTypeID, TestTypeName, TestDescriptionType, TestTypeFee);
            else
                return null;
        }

        public static DataTable GetAllTestTypes()
        {
            return clsTestTypeData.GetAllTestTypes();
        }

        public bool Save()
        {
            //switch(Mode)
            //{
            // case enMode.AddNew:
            // if(_AddNewTestType())
            // {
            // Mode = enMode.Update;
            // return true;
            // }
            // case enMode.Update:
            return _UpdateTestType();
            //}

            //   return false;
        }
    }
}
