using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class RedBlack
    {
        public RedBlack(Menu m)
        {
            B = m;
        }

        Random rnd = new Random();
        bool playAgain = true;
        Menu B = new Menu();
        public void RedOrBlackbet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("How much would you like to bet?");
            Console.ForegroundColor = ConsoleColor.White;
            int moneyBet = int.Parse(Console.ReadLine());
            int numBet = rnd.Next(1, 37);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Which one? 1) BLACK or 2) RED");
            Console.ForegroundColor = ConsoleColor.White;
            int userInput = int.Parse(Console.ReadLine());
            if (moneyBet <= B.userPot)
            {
                if (userInput == 1)
                {
                    if (numBet % 2 == 0)
                    {
                        B.userPot += (moneyBet);
                        Console.WriteLine("You Won!");
                        Console.WriteLine($"You have ${B.userPot} $$$");
                    }
                    else
                    {
                        B.userPot = B.userPot - moneyBet;
                        Console.WriteLine("Sorry, better luck next time.");
                        Console.WriteLine($"You have ${B.userPot} left");
                    }
                }
                if (userInput == 2)
                {
                    if (numBet % 2 != 0)
                    {
                        B.userPot += (moneyBet);
                        Console.WriteLine("You Won!");
                        Console.WriteLine($"You have ${B.userPot} dollars $$$");
                    }
                    else
                    {
                        B.userPot = B.userPot - moneyBet;
                        Console.WriteLine("Sorry, better luck next time.");
                        Console.WriteLine($"You have ${B.userPot}left");
                    }
                }
            }
            else
                Console.WriteLine("Sorry, you dont have enough money");

        }
    }
}
