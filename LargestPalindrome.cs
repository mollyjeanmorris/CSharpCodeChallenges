using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.CSharp
{
    class LargestPalindrome
    {
        static void Main(string[] args)
        {
            /* The largest palindrome made from the product of two 2-digit numbers is 
                9009 = 91 × 99. Find the largest palindrome made from the product of two 
                3-digit numbers.*/

            Console.WriteLine("The largest palindrom made from the product of two 3-digit number is...");
            Console.Read();
            List<int> listOfPalindromes = new List<int> { };
            for (int firstNumber = 999; firstNumber > 0; firstNumber--)
            {
                for (int secondNumber = 999; secondNumber > 0; secondNumber--)
                {
                    int product = firstNumber * secondNumber;
                    string productString = product.ToString();
                    int productLength = productString.Length;
                    string reverseString = "";

                    for (int i = productLength - 1; i > -1; i--)
                    {
                        reverseString += productString[i];
                    }

                    if (reverseString == productString)
                    {
                        listOfPalindromes.Add(product);
                    }
                }
            }
            listOfPalindromes.Sort();
            Console.WriteLine(listOfPalindromes.Max());
        } 
    }
}
