﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.CSharp
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            /*
            Each new term in the Fibonacci sequence is generated by adding the previous 
            two terms. By considering the terms in the Fibonacci sequence whose values do 
            not exceed four million, find the sum of the even-valued terms.
            */

            Console.WriteLine("Press any key to see the sum of the even-valued terms within a fibonacci sequence that does not exceed four million:");
            Console.Read();
            int a = 0;
            int max = 4000000;
            int sum = 0;
            int b = 1;

            while (b < max)
            {
                int temp = a;
                a = b;
                b = temp + a;
                //Console.WriteLine(b);

                if (b % 2 == 0)
                {
                    sum += b;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
