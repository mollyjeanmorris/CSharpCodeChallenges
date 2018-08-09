using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenges.CSharp
{
    class Atm
    {

        static void Main(string[] args)
        {
            // Highlights 
            // - asks the user to for an account number (hard coded)
            // - asks the user for a pin number (hard coded)
            // - once logged in, gives the user a menu to do a deposit, withdrawl, check balance, or exit
            // - after each transaction, returns user to menu
            // - thanks the user when they choose to exit

            int acceptableAccountNbr = 1234;
            decimal accountBalance = 0;
            int acceptablePin = 4321;
            for (int tries = 1; tries <= 3; tries++)
            {
                Console.WriteLine("Please enter your account number: ");
                int userAccountNbr = Convert.ToInt32(Console.ReadLine());

                if (acceptableAccountNbr == userAccountNbr)
                {
                    Console.WriteLine("Please enter your pin number: ");
                    int userPin = Convert.ToInt32(Console.ReadLine());

                    for (int pinTries = 1; pinTries <= 3; pinTries++)
                    {
                        if (acceptablePin == userPin)
                        {
                            Console.WriteLine("Menu");
                            Console.WriteLine("Here are your options:\n" +
                                "1. Deposit\n" +
                                "2. Withdrawl\n" +
                                "3. Check Balance\n" +
                                "4. Exit\n" +
                                "What would you like to do? Please enter the appropriate number.");
                            int userChoice = Convert.ToInt32(Console.ReadLine());

                            switch (userChoice)
                            {
                                case 1:
                                    Console.WriteLine("You chose deposit.\nHow much would you like to deposit?");
                                    decimal userDeposit = Convert.ToDecimal(Console.ReadLine());
                                    Console.WriteLine("You just deposited {0:c}. Thanks!", userDeposit);
                                    accountBalance += userDeposit;
                                    pinTries = 0;
                                    break;
                                case 2:
                                    Console.WriteLine("You chose withdrawal.\nHow much would you like to withdrawl?");
                                    decimal userWithdrawl = Convert.ToDecimal(Console.ReadLine());
                                    if (userWithdrawl > accountBalance)
                                    {
                                        Console.WriteLine("Transaction denied. Try again.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("You just withdrew {0:c}. Thanks!", userWithdrawl);
                                        accountBalance -= userWithdrawl;
                                    }
                                    pinTries = 0;
                                    break;
                                case 3:
                                    Console.WriteLine("Your balance: {0:c}", accountBalance);
                                    pinTries = 0;
                                    break;
                                case 4:
                                    Console.WriteLine("Thanks for using our services.");
                                    pinTries = 3;
                                    break;
                            } // end switch
                        }
                        else if (userPin != acceptablePin)
                        {
                            Console.WriteLine("Please try your pin again.");
                            userPin = Convert.ToInt32(Console.ReadLine());
                        }
                        //else
                        //{23
                        //    Console.WriteLine("Good try.");
                        //    pinTries = 3;
                        //}
                    }
                    // needed to end everything after user selects "ext"
                    tries = 3;
                } // end if
                else
                {
                    Console.WriteLine("Try your account number again.");
                } // end else
            }
        }
    }
}
