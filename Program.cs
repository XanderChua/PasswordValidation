using System;
using System.Text.RegularExpressions;

namespace PasswordValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            var hasLowerChar = new Regex(@"[a-z]+");     
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{6,24}");
            var hasNumber = new Regex(@"[0-9]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            Console.WriteLine("Password must contain an upper and lower case letter, numbers, special characters and between 6 to 24 characters long.");
            Console.WriteLine("Enter password: ");  
            string password = Console.ReadLine();

            if (!hasLowerChar.IsMatch(password))
            {
                Console.WriteLine("Password should contain at least one lower case letter");
            }
            else if (!hasUpperChar.IsMatch(password))
            {
                Console.WriteLine("Password should contain at least one upper case letter");
            }
            else if (!hasMiniMaxChars.IsMatch(password))
            {
                Console.WriteLine("Password should be between 6 and 24 characters");
            }
            else if (!hasNumber.IsMatch(password))
            {
                Console.WriteLine("Password should contain at least one number");
            }
            else if (!hasSymbols.IsMatch(password))
            {
                Console.WriteLine("Password should contain at least one special case characters");
            }
            else
            {
                Console.WriteLine("Password success!");
            }


        }
    }
}
