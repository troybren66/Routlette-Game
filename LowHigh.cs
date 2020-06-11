using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class LowHigh
    {
        Random rnd = new Random();
        bool playAgain = true;
        Menu B = new Menu();
        public LowHigh(Menu m)
        {
            B = m;
        }
        public void LowOrHighBet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("How much would you like to bet?");
            Console.ForegroundColor = ConsoleColor.White;
            int moneyBet = int.Parse(Console.ReadLine());
            int numBet = rnd.Next(1, 37);
            Console.WriteLine("Which one? 1) LOW or 2) HIGH");
            int userInput = int.Parse(Console.ReadLine());
            if (moneyBet <= B.userPot)
            {
                if (userInput == 1)
                {
                    if (numBet > 0 && numBet < 19)
                    {
                        B.userPot += (moneyBet);
                        Console.WriteLine("You Won!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"You have {B.userPot} dollars $$$");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        B.userPot = B.userPot - moneyBet;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, better luck next time.");
                        Console.WriteLine($"You have ${B.userPot} left");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
                if (userInput == 2)
                {
                    if (numBet > 18 && numBet < 37)
                    {
                        B.userPot += (moneyBet);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You Won!");
                        Console.WriteLine($"You have ${B.userPot} dollars $$$");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        B.userPot = B.userPot - moneyBet;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, better luck next time.");
                        Console.WriteLine($"You have ${B.userPot} left");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                }
            }
            else
                Console.WriteLine("Sorry, you don't have enough money.");

        }
    }
}
