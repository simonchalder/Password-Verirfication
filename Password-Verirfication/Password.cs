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
            char[] specialChars = { '!', '@', '#', '$', '%', '&', '*', '?', ',', '.', '-', '_', '<', '>', '=', '+'};
            foreach(char character in specialChars) 
            {
                int CharinPassword = Array.IndexOf(passArray, character);
                if(CharinPassword > -1)
                {
                    return true;
                }              
            }
            return false;
        }

        public bool getUppers(string password)
        {
            char[] passArray = password.ToCharArray();
            foreach(char character in passArray)
            {
                bool isUpper = Char.IsUpper(character);
                if(isUpper == true)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
