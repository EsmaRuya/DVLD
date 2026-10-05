using System;
using System.ComponentModel;
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

        public static bool isTxtEmpty(TextBox txt, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt.Text.Trim()))
                return true;
            else 
                return false;
        }

        public static bool isNumber(string num)
        {
            decimal result;
            return decimal.TryParse(num, out result);
        }

    }
}
