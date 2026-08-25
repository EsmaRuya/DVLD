using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DVLD.Global_Classes
{
    internal class clsValidation
    {
        public static bool validateEmail(string emailAddress)
        {
            var pattern = @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$";

            var regex = new Regex(pattern);

            return regex.IsMatch(emailAddress);
        }

       
    }
}
