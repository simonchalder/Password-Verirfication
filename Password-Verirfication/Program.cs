using System;
using System.IO;
using Spectre.Console;

namespace Password_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                Console.Clear();

                AnsiConsole.MarkupLine("[bold green]Loading wordlist.....[/]");

                Password newPassword = new Password(); // New password object

                Console.Clear();

                var titlerule = new Rule("[red]Password Strength Checker[/]");
                titlerule.Alignment = Justify.Left;
                AnsiConsole.Render(titlerule);

                Console.WriteLine("\nEnter your password: ");

                newPassword.password = Console.ReadLine();

                Console.WriteLine("\n");
                var resultsrule = new Rule("[red]Results[/]");
                resultsrule.Alignment = Justify.Left;
                AnsiConsole.Render(resultsrule);
                Console.WriteLine("\n");

                bool result = newPassword.CheckPasswordAgainstWordlist(newPassword.password);

                if (result == true)
                {
                    AnsiConsole.MarkupLine("Password is a [bold red]commonly used password[/], choose another");
                }
                else
                {
                    AnsiConsole.MarkupLine("Password is [bold green]not commonly used[/]");
                }

                int length = newPassword.getLength(newPassword.password);
                if (length < 8)
                {
                    AnsiConsole.MarkupLine("Password is[bold red] less than 8 characters[/], consider a longer password");
                }
                else
                {
                    AnsiConsole.MarkupLine($"Password is[bold green] {length} characters[/] long which is good");
                }

                bool hasSpecChar = newPassword.getSpecialChars(newPassword.password);

                if (hasSpecChar == true)
                {
                    AnsiConsole.MarkupLine($"Password [bold green]contains special characters[/] which is more secure");
                }
                else
                {
                    AnsiConsole.MarkupLine("Password does[bold red] not contain any special characters[/], consider adding one or more");
                }

                bool hasUpper = newPassword.getUppers(newPassword.password);

                if (hasUpper == true)
                {
                    AnsiConsole.MarkupLine($"Password [bold green]contains UPPERCASE characters[/] which is more secure");
                }
                else
                {
                    AnsiConsole.MarkupLine("Password does[bold red] not contain any UPPERCASE characters[/], consider adding one or more");
                }

                Console.WriteLine("\n");
                var rule = new Rule();
                rule.Alignment = Justify.Left;
                AnsiConsole.Render(rule);
                Console.WriteLine("\n");

                Console.WriteLine("Try another password? Type 'Y' to try again, or anything else to quit");
                string stringInput = Console.ReadLine(); // Exception handling for if user simply presses enter without entering a response
                if(stringInput.Length > 0)
                {
                    char input = Char.Parse(stringInput);
                    if (Char.ToUpper(input) == 'Y')
                    {
                        repeat = true;
                    }
                    else
                    {
                        repeat = false;
                    }
                }
                else
                {
                    repeat = false;
                }
                
            } while (repeat == true);

        }
    }
}
