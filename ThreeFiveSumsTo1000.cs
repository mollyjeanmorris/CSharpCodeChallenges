using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class ThreeFiveSumsTo1000
    {
        static void Main(string[] args)
        {
            //The sum of all the multiples of 3 or 5 below 1000
            Console.WriteLine("Press any key to see see the sum of all multiples of 3 or 5 below 1000:");
            Console.Read();
            int sumOfMultiples = 0;
            for (int i = 999; i > 0; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumOfMultiples += i;
                }
            }
            Console.WriteLine(sumOfMultiples);
        }
    }
}
