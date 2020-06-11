using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Streets
    {
        public Streets(Menu m)
        {
            B = m;
        }
        Random rnd = new Random();
        bool playAgain = true;
        bool didWin = false;
        Menu B = new Menu();
        public void StreetsBet()
        {
            int[] street1 = new int[] { 1, 2, 3 };
            int[] street2 = new int[] { 4, 5, 6 };
            int[] street3 = new int[] { 7, 8, 9 };
            int[] street4 = new int[] { 10, 11, 12 };
            int[] street5 = new int[] { 13, 14, 15 };
            int[] street6 = new int[] { 16, 17, 18 };
            int[] street7 = new int[] { 19, 20, 21 };
            int[] street8 = new int[] { 22, 23, 24 };
            int[] street9 = new int[] { 25, 26, 27 };
            int[] street10 = new int[] { 28, 29, 30 };
            int[] street11 = new int[] { 31, 32, 33 };
            int[] street12 = new int[] { 34, 35, 36 };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("How much would you like to bet?");
            Console.ForegroundColor = ConsoleColor.White;
            int moneyBet = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What street (row) do you want to bet on? (Choose a number between 1 and 12)");
            Console.ForegroundColor = ConsoleColor.White;
            int userInput = int.Parse(Console.ReadLine());
            int numBet = rnd.Next(1, 37);
            if (moneyBet <= B.userPot)
            {
                if (userInput == 1)
                {
                    for (int i = 0; i < street1.Length; i++)
                    {
                        if (street1[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 11);
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
                    for (int i = 0; i < street2.Length; i++)
                    {
                        if (street2[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 11);
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
                    for (int i = 0; i < street3.Length; i++)
                    {
                        if (street3[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 11);
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
                    for (int i = 0; i < street4.Length; i++)
                    {
                        if (street4[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 11);
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
                    for (int i = 0; i < street5.Length; i++)
                    {
                        if (street5[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 11);
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
                    for (int i = 0; i < street6.Length; i++)
                    {
                        if (street6[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 11);
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
                if (userInput == 7)
                {
                    for (int i = 0; i < street7.Length; i++)
                    {
                        if (street7[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 11);
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
                if (userInput == 8)
                {
                    for (int i = 0; i < street8.Length; i++)
                    {
                        if (street8[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 11);
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
                if (userInput == 9)
                {
                    for (int i = 0; i < street9.Length; i++)
                    {
                        if (street9[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 11);
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
                if (userInput == 10)
                {
                    for (int i = 0; i < street10.Length; i++)
                    {
                        if (street10[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 11);
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
                if (userInput == 11)
                {
                    for (int i = 0; i < street11.Length; i++)
                    {
                        if (street11[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 11);
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
                if (userInput == 12)
                {
                    for (int i = 0; i < street12.Length; i++)
                    {
                        if (street12[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 11);
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
                Console.WriteLine("You dont have enough money.");
        }
    }
}
