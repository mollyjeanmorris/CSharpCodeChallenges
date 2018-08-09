using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.CSharp
{
    class PalindromeChecker
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palindrome Checker");
            Console.WriteLine("Please enter a word to check if it's a palindrome:");
            string userWord = Console.ReadLine().ToLower();
            string backwards = "";
            int wordLength = userWord.Length;

            for (int i = wordLength - 1; i > -1; i--)
            {
                backwards += userWord[i];
            }

            if (userWord == backwards)
            {
                Console.WriteLine("Your word is a palindrome!");
            }
            else
            {
                Console.WriteLine("Your word is isn't palindrom. Womp!");
            }

        }
    }
}
