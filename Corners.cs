using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Corners
    {
        public Corners(Menu m)
        {
            B = m;
        }
        Random rnd = new Random();
        bool playAgain = true;
        bool didWin = false;
        Menu B = new Menu();
        public void ConersBet()
        {
            int[] corner1 = new int[] { 1, 2, 4, 5 };
            int[] corner2 = new int[] { 4, 5, 7, 8 };
            int[] corner3 = new int[] { 7, 8, 10, 11 };
            int[] corner4 = new int[] { 10, 11, 13, 14 };
            int[] corner5 = new int[] { 13, 14, 16, 17 };
            int[] corner6 = new int[] { 16, 17, 19, 20 };
            int[] corner7 = new int[] { 19, 20, 22, 23 };
            int[] corner8 = new int[] { 22, 23, 25, 26 };
            int[] corner9 = new int[] { 25, 26, 28, 29 };
            int[] corner10 = new int[] { 28, 29, 31, 32 };
            int[] corner11 = new int[] { 31, 32, 34, 35 };
            int[] corner12 = new int[] { 2, 3, 5, 6 };
            int[] corner13 = new int[] { 5, 6, 8, 9 };
            int[] corner14 = new int[] { 8, 9, 11, 12 };
            int[] corner15 = new int[] { 11, 12, 14, 15 };
            int[] corner16 = new int[] { 14, 15, 17, 18 };
            int[] corner17 = new int[] { 17, 18, 20, 21 };
            int[] corner18 = new int[] { 20, 21, 23, 24 };
            int[] corner19 = new int[] { 23, 24, 26, 27 };
            int[] corner20 = new int[] { 26, 27, 29, 30 };
            int[] corner21 = new int[] { 29, 30, 32, 33 };
            int[] corner22 = new int[] { 32, 33, 35, 36 };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("How much would you like to bet?");
            Console.ForegroundColor = ConsoleColor.White;
            int moneyBet = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Select a Corner to bet on");
            Console.ForegroundColor = ConsoleColor.White;
            int userInput = int.Parse(Console.ReadLine());
            int numBet = rnd.Next(1, 37);
            if (moneyBet <= B.userPot)
            {
                if (userInput == 1)
                {
                    for (int i = 0; i < corner1.Length; i++)
                    {
                        if (corner1[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                    for (int i = 0; i < corner2.Length; i++)
                    {
                        if (corner2[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                    for (int i = 0; i < corner3.Length; i++)
                    {
                        if (corner3[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                    for (int i = 0; i < corner4.Length; i++)
                    {
                        if (corner4[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                    for (int i = 0; i < corner5.Length; i++)
                    {
                        if (corner5[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                    for (int i = 0; i < corner6.Length; i++)
                    {
                        if (corner6[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                    for (int i = 0; i < corner7.Length; i++)
                    {
                        if (corner7[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                    for (int i = 0; i < corner8.Length; i++)
                    {
                        if (corner8[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                    for (int i = 0; i < corner9.Length; i++)
                    {
                        if (corner9[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                    for (int i = 0; i < corner10.Length; i++)
                    {
                        if (corner10[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                    for (int i = 0; i < corner11.Length; i++)
                    {
                        if (corner11[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                    for (int i = 0; i < corner12.Length; i++)
                    {
                        if (corner12[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                if (userInput == 13)
                {
                    for (int i = 0; i < corner13.Length; i++)
                    {
                        if (corner13[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                if (userInput == 14)
                {
                    for (int i = 0; i < corner14.Length; i++)
                    {
                        if (corner14[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                if (userInput == 15)
                {
                    for (int i = 0; i < corner15.Length; i++)
                    {
                        if (corner15[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                if (userInput == 16)
                {
                    for (int i = 0; i < corner16.Length; i++)
                    {
                        if (corner16[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                if (userInput == 17)
                {
                    for (int i = 0; i < corner17.Length; i++)
                    {
                        if (corner17[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                if (userInput == 18)
                {
                    for (int i = 0; i < corner18.Length; i++)
                    {
                        if (corner18[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                if (userInput == 19)
                {
                    for (int i = 0; i < corner19.Length; i++)
                    {
                        if (corner19[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                if (userInput == 20)
                {
                    for (int i = 0; i < corner20.Length; i++)
                    {
                        if (corner20[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                if (userInput == 21)
                {
                    for (int i = 0; i < corner21.Length; i++)
                    {
                        if (corner21[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                if (userInput == 22)
                {
                    for (int i = 0; i < corner22.Length; i++)
                    {
                        if (corner22[i] == numBet)
                        {
                            didWin = true;
                            B.userPot += (moneyBet * 8);
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
                Console.WriteLine("Sorry, you dont have enough money");

        }
    }
}
