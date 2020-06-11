using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Dozens
    {
        public Dozens(Menu m)
        {
            B = m;
        }

        Random rnd = new Random();
        bool playAgain = true;
        Menu B = new Menu();
        public void DozensBet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("How much would you like to bet?");
            Console.ForegroundColor = ConsoleColor.White;
            int moneyBet = int.Parse(Console.ReadLine());
            int numBet = rnd.Next(1, 37);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Which set of dozens do you want to bet on? \n1) 1-12 \n2) 13-24 \n3) 25-36");
            Console.ForegroundColor = ConsoleColor.White;
            int userInput = int.Parse(Console.ReadLine());
            if (moneyBet <= B.userPot)
            {
                if (userInput == 1)
                {
                    if (numBet >= 1 && numBet <= 12)
                    {
                        B.userPot += (moneyBet * 2);
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
                if (userInput == 2)
                {
                    if (numBet >= 13 && numBet <= 24)
                    {
                        B.userPot += (moneyBet * 2);
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
                if (userInput == 3)
                {
                    if (numBet >= 25 && numBet <= 36)
                    {
                        B.userPot += (moneyBet * 2);
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
                Console.WriteLine("Sorry, you dont have enough money");
        }
    }
}
