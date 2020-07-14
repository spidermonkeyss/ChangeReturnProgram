//Change Return Program – The user enters a cost and then the amount of money given. The program will figure out the change and the number of quarters, dimes, nickels, pennies needed for the change.
using System;
using Utlity;

namespace ChangeReturnProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            float cost = UserInput.GetUserFloatInput();
            float moneyGiven = UserInput.GetUserFloatInput();

            //I switch these to ints to remove and imprecise floating points
            int cost_ = (int)(Math.Round(cost, 2) * 100);
            int moneyGiven_ = (int)(Math.Round(moneyGiven, 2) * 100);

            int change = moneyGiven_ - cost_;
            //Get Quarters
            int changeAfterQuarters = change % 25;
            int amountForQuarters = change - changeAfterQuarters;
            int numOfQuarters = amountForQuarters / 25;
            //Get dimes
            int changeAfterDimes = changeAfterQuarters % 10;
            int amountForDimes = changeAfterQuarters - changeAfterDimes;
            int numOfDimes = amountForDimes / 10;

            //Get nickels
            int changeAfterNickels = changeAfterDimes % 5;
            int amountForNickels = changeAfterDimes - changeAfterNickels;
            int numOfNickels = amountForNickels / 5;

            //Get pennies
            int numOfPennies = changeAfterNickels;

            Console.WriteLine("Quarter " + numOfQuarters);
            Console.WriteLine("Dimes " + numOfDimes);
            Console.WriteLine("Nickels " + numOfNickels);
            Console.WriteLine("Pennies " + numOfPennies);
        }
    }
}
