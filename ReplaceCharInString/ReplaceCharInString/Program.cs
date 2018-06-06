using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ReplaceCharInString
{
    class Program
    {
        public static string replaceWord(string[]splitStr,string replStr, string newStr )
        {
          //Create a string builder that will recreate the string after replacement of the word.
            StringBuilder sb = new StringBuilder();

            int i = 0;
            foreach(string x in splitStr)
            {
              i = i +1;
              if (x == replStr)
              {
                  // if the word to be replaced is found then replace it with the new word.
                  sb.Append(newStr);
                  sb.Append(" ");   // Always add the space after each word has been added.
                  
              }
              else   // if the word is is not this one add the orignal word to the string.
              {
                  sb.Append(x);    
                  sb.Append(" ");   // add a space after each word has been added
              
              }
               
            }
            return sb.ToString();
        
        }

        public static string replaceChar(string s, string oldChar, string newChar)
        {
            // This will reconstruct the string.
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                //Compare the characters
                if (c.ToString() == oldChar)
                {
                    //if it is the targeted char replace it.
                    sb.Append(newChar);
                }
                else
                {
                    // reconstruct the string with string builder
                    sb.Append(c);
                }
            
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the char to be replaced: ");
            string tobeReplaced = Console.ReadLine();
            Console.WriteLine("Enter a new char to replace: ");
            string newReplacement = Console.ReadLine();
            
            //Create array to split the string into individual words for ease search
            string [] myarr = new string [50];

            //The splitter will be the empty space between the words in the string
            myarr = s.Split(' ');
            
           //Console.WriteLine(replaceWord(myarr,a,b).Trim());
            Console.WriteLine(replaceChar(s, tobeReplaced, newReplacement));
           Console.ReadLine();
      }
    }
}
