using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.CSharp
{
    class TempConversion
    {
        static void Main(string[] args)
        {
            decimal cel;
            decimal kelvin;
            decimal fah;
            bool exit = false;
            while (exit != true)
            {
                Console.WriteLine("Which conversion do you want?");
                Console.WriteLine("1 Celsius -> Fahrenheit\n2 Celsius -> Kelvin\n3 Fahrenheit -> Celsius\n4 Fahrenheit -> Kelvin\n5 Kelvin -> Celsius\n6 Kelvin -> Farhrenheit\n7 Exit");
                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        // Celsius -> Fahrenheit
                        Console.WriteLine("Please enter starting Celsius temperature: ");
                        cel = Convert.ToDecimal(Console.ReadLine());
                        fah = (cel *(9/5)) + 32;
                        Console.WriteLine("Temperature in Fahrenheit:  {0:n0}", fah);
                        break;
                    case "2":
                        // Celsius -> Kelvin
                        Console.WriteLine("Please enter starting Celsius temperature: ");
                        cel = Convert.ToDecimal(Console.ReadLine());
                        kelvin = cel + 273;
                        Console.WriteLine("Temperature in Kelvin:{0:n0}",kelvin);
                        break;
                    case "3":
                        // Fahrenheit - > Celsius
                        Console.WriteLine("Please enter starting Fahrenheit temperature: ");
                        fah = Convert.ToDecimal(Console.ReadLine());
                        cel = ((fah - 32) * (5m / 9m));
                        Console.WriteLine("Temperature in Celsius: {0:n0}",cel);
                        break;
                    case "4":
                        // Fahrenheit - > Kelvin
                        Console.WriteLine("Please enter starting Fahrenheit temperature: ");
                        fah = Convert.ToDecimal(Console.ReadLine());
                        kelvin = ((fah + 459) * (5m / 9m));
                        Console.WriteLine("Temperature in Kelvin: {0:n0}", kelvin);
                        break;
                    case "5":
                        // Kelvin - > Celsius
                        Console.WriteLine("Please enter starting Kelvin temperature: ");
                        kelvin = Convert.ToDecimal(Console.ReadLine());
                        cel = kelvin - 273;
                        Console.WriteLine("Temperature in Celsius: {0:n0}", cel);
                        break;
                    case "6":
                        // Kelvin - > Fahrenheit
                        Console.WriteLine("Please enter starting Kelvin temperature: ");
                        kelvin = Convert.ToDecimal(Console.ReadLine());
                        fah = (kelvin * (1.8m)) - 459.67m;
                        Console.WriteLine("Temperature in Fahrenheit: {0:n0}", fah);
                        break;
                    case "7":
                        exit = true;
                        Console.WriteLine("Goodbye.");
                        break;
                    default:
                        Console.WriteLine("I don't understand your choice. Try again.");
                        break;
                }
            }
        }
    }
}
