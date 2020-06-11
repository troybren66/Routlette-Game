using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class EvenOdd
    {
        Random rnd = new Random();
        bool playAgain = true;
        Menu B;

        public EvenOdd(Menu m)
        {
            B = m;
        }
        public void EvenOrOddBet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("How much would you like to bet?");
            Console.ForegroundColor = ConsoleColor.White;
            int moneyBet = int.Parse(Console.ReadLine());
            int numBet = rnd.Next(1, 37);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Which One? 1) EVEN or 2) ODD");
            Console.ForegroundColor = ConsoleColor.White;
            int userInput = int.Parse(Console.ReadLine());
            if (moneyBet <= B.userPot)
            {
                if (userInput == 1)
                {
                    if (numBet % 2 == 0)
                    {
                        B.userPot += moneyBet;
                        Console.WriteLine("You Won!");
                        Console.WriteLine($"You have ${B.userPot} dollars $$$");
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
                        B.userPot += moneyBet;
                        Console.WriteLine("You Won!");
                        Console.WriteLine($"You have {B.userPot} dollars $$$");
                    }
                    else
                    {
                        B.userPot = B.userPot - moneyBet;
                        Console.WriteLine("Sorry, better luck next time.");
                        Console.WriteLine($"You have ${B.userPot} left");
                    }
                }
            }
            else
                Console.WriteLine("Sorry, you dont have enough money");
        }
    }
}