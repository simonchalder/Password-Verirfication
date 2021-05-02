using System;
using System.IO;

namespace Password_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            Password newPassword = new Password(); // New password object

            Console.WriteLine("Enter your password: ");

            newPassword.password = Console.ReadLine();

            bool result = newPassword.CheckPasswordAgainstWordlist(newPassword.password);

            if (result == true)
            {
                Console.WriteLine("Password is a commonly used password, choose another");
            }
            else
            {
                Console.WriteLine("Password is not commonly used");
            }

            int length = newPassword.getLength(newPassword.password);
            if (length < 8)
            {
                Console.WriteLine("Password is less than 8 characters, consider a longer password");
            }
            else
            {
                Console.WriteLine($"Password is {length} characters long which is good");
            }

            bool hasSpecChar = newPassword.getSpecialChars(newPassword.password);
            
            if(hasSpecChar == true)
            {
                Console.WriteLine("Password contains special chracters which is stronger");
            }
            else
            {
                Console.WriteLine("Password does not contain any special characters");
            }
            Console.ReadLine();
        }
    }
}
