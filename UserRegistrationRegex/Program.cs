using System.ComponentModel.DataAnnotations;

namespace UserRegistrationRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problems!");
            UserRegistration validate1 = new UserRegistration();
            Console.Write("Enter Your First Name : ");
            string FirstName = Console.ReadLine();
            Console.WriteLine(validate1.ValidateFirstName(FirstName));
            Console.Write("Enter Your Last Name : ");
            string LastName = Console.ReadLine();
            Console.WriteLine(validate1.ValidateFirstName(LastName));

        }
    }
}