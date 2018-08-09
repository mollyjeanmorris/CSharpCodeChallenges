using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges
{
    class CollatzFromInput
    {
        static void Main(string[] args)
        {
            /* 
               Program that captures a whole number from a user and outputs a Collatz conjecture
               starting with their number. 
               A Collatz conjecture uses the following algorithm:
                o If n is even, divide it by 2 (n -> n/2)
                o If n is odd, multiply it by 3 and add 1 (n -> 3n + 1)
                o Eventually, all numbers resolve to 1
           */
            Console.WriteLine("Collatz Conjecture");
            Console.WriteLine("Please enter a whole number to see: ");
            int userNbr = int.Parse(Console.ReadLine());
            List<string> listOfNbrs = new List<string>();
            while (userNbr != 1)
            {
                if (userNbr % 2 == 0)
                {
                    userNbr = userNbr / 2;
                    listOfNbrs.Add(userNbr.ToString());
                }
                else
                {
                    userNbr = (userNbr * 3) + 1;
                    listOfNbrs.Add(userNbr.ToString());
                }

            }
            foreach (var item in listOfNbrs)
            {
                Console.WriteLine(item);
            }
        }
    }
}
