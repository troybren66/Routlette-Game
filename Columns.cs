using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Columns
    {
        public Columns(Menu m)
        {
            B = m;
        }
        Random rnd = new Random();
        bool playAgain = true;
        bool didWin = false;
        Menu B = new Menu();
        public void ColumnsBet()
        {
            int[] column1 = new int[] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
            int[] column2 = new int[] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
            int[] column3 = new int[] { 3, 6, 8, 12, 15, 18, 21, 24, 27, 30, 33, 36 };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("How much would you like to bet?");
            Console.ForegroundColor = ConsoleColor.White;
            int moneyBet = int.Parse(Console.ReadLine());
            int numBet = rnd.Next(1, 37);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What column do you want to bet on? 1, 2, or 3");
            Console.ForegroundColor = ConsoleColor.White;
            int userInput = int.Parse(Console.ReadLine());
            if (moneyBet <= B.userPot)
            {
                if (userInput == 1)
                {
                    for (int i = 0; i < column1.Length; i++)
                    {
                        if (column1[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 2);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You Won!");
                            Console.WriteLine($"You have ${B.userPot} dollars $$$");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    if (didWin == false)
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
                    for (int i = 0; i < column2.Length; i++)
                    {
                        if (column2[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 2);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You Won!");
                            Console.WriteLine($"You have ${B.userPot} dollars $$$");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    if (didWin == false)
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
                    for (int i = 0; i < column3.Length; i++)
                    {
                        if (column3[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 2);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You Won!");
                            Console.WriteLine($"You have ${B.userPot} dollars $$$");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    if (didWin == false)
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
                Console.WriteLine("Sorry, you don't have enough money");
        }
    }
}
