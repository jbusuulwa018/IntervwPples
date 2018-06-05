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
        static void Main(string[] args)
        {


            int f = 0;
            int start, end;
           
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the word to be replaced: ");
            string a = Console.ReadLine();
            Console.WriteLine("Enter a new word to replace: ");
            string b = Console.ReadLine();
            
            //Create array to split the string into individual words for ease search
            string [] myarr = new string [50];

            //The splitter will be the empty space between the words in the string
            myarr = s.Split(' ');
            
           Console.WriteLine(replaceWord(myarr,a,b).Trim());
           Console.ReadLine();
      }
    }
}
