using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Number
    {
        Random rnd = new Random();
        bool playAgain = true;
        Menu B;

        public Number(Menu m)
        {
            B = m;
        }
        public void NumberBet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("How much would you like to bet?");
            Console.ForegroundColor = ConsoleColor.White;
            int moneyBet = int.Parse(Console.ReadLine());
            if (moneyBet <= B.userPot)
            {
                Console.WriteLine("What number would you like to bet on between 1 and 36?");
                int userInput = int.Parse(Console.ReadLine());
                int numBet = rnd.Next(1, 39);
                if (userInput > 0 && userInput < 39)
                {
                    if (userInput == numBet)
                    {
                        B.userPot = B.userPot + (moneyBet * 35);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You Won!");
                        Console.WriteLine($"You have ${B.userPot} dollars $$$");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (userInput != numBet)
                    {
                        B.userPot = B.userPot - moneyBet;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You Lost!");
                        Console.WriteLine($" You have ${B.userPot} left");
                        Console.ForegroundColor = ConsoleColor.White;
                        playAgain = false;
                    }
                }
            }
            else
                Console.WriteLine("Sorry. You don't have enough money");
        }
    }
}
