using DVLD_DataAccess;
using System;
using System.Data;

namespace DVLD_Business
{
    public class clsApllicationType
    {
        int _ApplicationTypesId = -1; 
        string _ApplicationTitle = "";
        float _ApplicationFees = -1;

        clsApllicationType()
        {
            _ApplicationTypesId = -1;
            _ApplicationTitle = "";
            _ApplicationFees = -1;
        }

        clsApllicationType(int ApplicationTypesId, string ApplicationTitle, float ApplicationFees)
        {
            _ApplicationTypesId = ApplicationTypesId;
            _ApplicationTitle = ApplicationTitle;
            _ApplicationFees = ApplicationFees;
        }

        public bool UpdateApplicationType()
        {
            return clsApllicationTypeData.UpdateApplicationType(_ApplicationTypesId, _ApplicationTitle, _ApplicationFees );
        }

        public static clsApllicationType Find(int AppTypeID)
        {
            string AppTypeName = "";
            float AppTypeFee = -1;
            if (clsApllicationTypeData.GetApplicationTypeByID(AppTypeID, ref AppTypeName, ref AppTypeFee))
                return new clsApllicationType(AppTypeID, AppTypeName, AppTypeFee);
            else
                return null;
        }

        public static DataTable GetAllApplicationTypes()
        {
            return clsApllicationTypeData.GetAllApplicationTypes();
        }

    }
}
