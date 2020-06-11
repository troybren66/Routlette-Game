using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Sixes
    {
        public Sixes(Menu m)
        {
            B = m;
        }
        Random rnd = new Random();
        bool playAgain = true;
        bool didWin = false;
        Menu B = new Menu();
        public void SetsOfSixBet()
        {
            int[] set1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] set2 = new int[] { 7, 8, 9, 10, 11, 12 };
            int[] set3 = new int[] { 13, 14, 15, 16, 17, 18 };
            int[] set4 = new int[] { 19, 20, 21, 22, 23, 24 };
            int[] set5 = new int[] { 25, 26, 27, 28, 29, 30 };
            int[] set6 = new int[] { 31, 32, 33, 34, 35, 36 };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("How much would you like to bet?");
            Console.ForegroundColor = ConsoleColor.White;
            int moneyBet = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What set of 6 do you want to bet on? \n1) 1-6 \n2) 7-12 \n3) 13-18 \n4) 19-24 \n5) 25-30 \n6) 31-36");
            Console.ForegroundColor = ConsoleColor.White;
            int userInput = int.Parse(Console.ReadLine());
            int numBet = rnd.Next(1, 37);
            if (moneyBet <= B.userPot)
            {
                if (userInput == 1)
                {
                    for (int i = 0; i < set1.Length; i++)
                    {
                        if (set1[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 5);
                            Console.WriteLine("You Won!");
                            Console.WriteLine($"You have ${B.userPot} dollars $$$");
                        }
                    }
                    if (didWin == false)
                    {
                        B.userPot = B.userPot - moneyBet;
                        Console.WriteLine("Sorry, better luck next time.");
                        Console.WriteLine($"You have ${B.userPot} left");
                    }
                }
                if (userInput == 2)
                {
                    for (int i = 0; i < set2.Length; i++)
                    {
                        if (set2[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 5);
                            Console.WriteLine("You Won!");
                            Console.WriteLine($"You have ${B.userPot} dollars $$$");
                        }
                    }
                    if (didWin == false)
                    {
                        B.userPot = B.userPot - moneyBet;
                        Console.WriteLine("Sorry, better luck next time.");
                        Console.WriteLine($"You have ${B.userPot} left");
                    }
                }
                if (userInput == 3)
                {
                    for (int i = 0; i < set3.Length; i++)
                    {
                        if (set3[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 5);
                            Console.WriteLine("You Won!");
                            Console.WriteLine($"You have ${B.userPot} dollars $$$");
                        }
                    }
                    if (didWin == false)
                    {
                        B.userPot = B.userPot - moneyBet;
                        Console.WriteLine("Sorry, better luck next time.");
                        Console.WriteLine($"You have ${B.userPot} left");
                    }
                }
                if (userInput == 4)
                {
                    for (int i = 0; i < set4.Length; i++)
                    {
                        if (set4[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 5);
                            Console.WriteLine("You Won!");
                            Console.WriteLine($"You have ${B.userPot} dollars $$$");
                        }
                    }
                    if (didWin == false)
                    {
                        B.userPot = B.userPot - moneyBet;
                        Console.WriteLine("Sorry, better luck next time.");
                        Console.WriteLine($"You have ${B.userPot} left");
                    }
                }
                if (userInput == 5)
                {
                    for (int i = 0; i < set5.Length; i++)
                    {
                        if (set5[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 5);
                            Console.WriteLine("You Won!");
                            Console.WriteLine($"You have ${B.userPot} dollars $$$");
                        }
                    }
                    if (didWin == false)
                    {
                        B.userPot = B.userPot - moneyBet;
                        Console.WriteLine("Sorry, better luck next time.");
                        Console.WriteLine($"You have ${B.userPot} left");
                    }
                }
                if (userInput == 6)
                {
                    for (int i = 0; i < set6.Length; i++)
                    {
                        if (set6[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 5);
                            Console.WriteLine("You Won!");
                            Console.WriteLine($"You have ${B.userPot} dollars $$$");
                        }
                    }
                    if (didWin == false)
                    {
                        B.userPot = B.userPot - moneyBet;
                        Console.WriteLine("Sorry, better luck next time.");
                        Console.WriteLine($"You have ${B.userPot} left");
                    }
                }
            }
            else
                Console.WriteLine("Sorry. You don't have enough money");
        }

    }
}
