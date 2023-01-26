using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    internal class UserRegistration
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidateFirstName(string firstName)
        {
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }
        public static string Regex_LastName = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Regex_LastName);
        }
        public const string Regex_Email = "^[a-zA-Z0-9]+@[a-zA-Z]+.+([co.in|com|in])$";
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
        public const string Regex_MobileNumber = "^[0-9]{1,3}[ ][0-9]{10}$";
        public bool ValidateMobileNumber(string MobNum)
        {
            return Regex.IsMatch(MobNum, Regex_MobileNumber);
        }
        public const string Regex_password = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*?<>]).{6,15}$"; //rule3
        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_password);
        }
    }
}
