using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    public class UserRegistration
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
        public const string Regex_Email = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
        public const string Regex_MobileNumber = "^[0-9]{1,3}[ ][0-9]{10}$";
        public bool ValidateMobileNumber(string MobNum)
        {
            return Regex.IsMatch(MobNum, Regex_MobileNumber);
        }
        public const string Regex_password = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*?<>]).{8,}$"; //rule4
        public bool ValidatePassword(string Password)
        {
            return Regex.IsMatch(Password, Regex_password);
        }
        public void Test()
        {
            UserRegistration validate = new UserRegistration();
            Console.WriteLine("A. Valid Emails");
            string[] validEmails = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            for (int i = 0; i < validEmails.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + validEmails[i] + " : " + validate.ValidateEmail(validEmails[i]));
            }
            Console.WriteLine("\nB. Invalid Emails");
            string[] invalidEmails = { "abc", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc@%*.com", "abc..2002@gmail.com", "abc.@gmail.com", "abc@abc@gmail.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            for (int i = 0; i < invalidEmails.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + invalidEmails[i] + " : " + validate.ValidateEmail(invalidEmails[i]));
            }


        }
        public string Email(string email)
        {
            Regex regex = new Regex(Regex_Email);

            bool result = regex.IsMatch(email);
            if (result)
            {
                return email;
            }
            else
            {
                return default;
            }
            throw new NotImplementedException();
        }
    }
}
