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
            Console.WriteLine($"Password is {length} characters long");

            Console.ReadLine();
        }
    }
}
