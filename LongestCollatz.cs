using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.CSharp
{
    class LongestCollatz
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The following is longest collatz under 1000... ");
            Console.Read();
            int startNbr = 0;
            int chainNbr = 0;
            Dictionary<int, int> collatzDictionary = new Dictionary<int, int>();
            for (int i = 2; i < 999; i++)
            {
                startNbr = i;
                chainNbr = 0;
                int temp = i;

                while (temp != 1)
                {
                    if (temp % 2 == 0)
                    {
                        temp = temp / 2;
                        chainNbr++;
                    }
                    else
                    {
                        temp = (temp * 3) + 1;
                        chainNbr++;
                    }
                }//while loop
                collatzDictionary.Add(startNbr, chainNbr);
            }//for loop

            int longestChainStartNbr = collatzDictionary.OrderByDescending(x => x.Value).FirstOrDefault().Key;

            Console.WriteLine($"Longest chain: {collatzDictionary[longestChainStartNbr]}\nStart number: {longestChainStartNbr}");
        }
    }
}
