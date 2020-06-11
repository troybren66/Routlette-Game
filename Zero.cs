using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Zero
    {
        public Zero(Menu m)
        {
            B = m;
        }
        Random rnd = new Random();
        bool playAgain = true;
        Menu B = new Menu();
        public void Zeros()
        {
            Console.WriteLine("How much would you like to bet?");
            int moneyBet = int.Parse(Console.ReadLine());
            Console.WriteLine("To place a bet on 0 or 00, please enter 37 or 38");
            int userInput = int.Parse(Console.ReadLine());
            int numBet = rnd.Next(1, 39);
            if (userInput == 37 || userInput == 38)
            {

                if (userInput == numBet)
                {
                    B.userPot = B.userPot + (moneyBet * 35);
                    Console.WriteLine("You Won!");
                    Console.WriteLine($"You have ${B.userPot} dollars $$$");
                }
                else if (userInput != numBet)
                {
                    B.userPot = B.userPot - moneyBet;
                    Console.WriteLine("You Lost!");
                    Console.WriteLine($" You have ${B.userPot} left");
                    playAgain = false;
                }
            }
            else
                Console.WriteLine("Please Enter a valid Number");
        }
    }
}
