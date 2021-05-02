using System;
using System.Collections.Generic;
using System.Text;

namespace Password_Checker
{
    class Password //Password class
    {
        string[] wordlist = System.IO.File.ReadAllLines(@"../../../wordlist.txt");
        public string password { get; set; }

        public bool CheckPasswordAgainstWordlist(string password)
        {
            int isInWordlist = Array.IndexOf(wordlist, password);

            if (isInWordlist > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getLength(string password)
        {
            int length = password.Length;
            return length;
        }

        public bool getSpecialChars(string password)
        {
            bool specChar;
            char[] passArray = password.ToCharArray();
            char[] specialChars = { '!', '@', '#', '$', '%', '&', '*', '?' };
            foreach(char character in specialChars) 
            {
                int CharinPassword = Array.IndexOf(passArray, character);
                if(CharinPassword > -1)
                {
                    return specChar = true;
                }              
            }
            return specChar = false;
        }
    }
}
