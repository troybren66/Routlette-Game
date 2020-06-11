using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Menu
    {
        public decimal userPot { get; set; }
        Random rnd = new Random();
        bool playAgain = true;
        //Program p = new Program();
        public void playerMenu()
        {
            userPot = 5000;
            while (playAgain == true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("1) Bet on a number");
                Console.WriteLine("2) Bet on EVENZ or ODDZ");
                Console.WriteLine("3) Bet on RED or BLACK");
                Console.WriteLine("4) Bet on LOWZ or HIGHZ");
                Console.WriteLine("5) Bet on DOZENZ");
                Console.WriteLine("6) Bet on COLUMNZ");
                Console.WriteLine("7) Bet on STREETZ");
                Console.WriteLine("8) Bet on SETS of SIX");
                Console.WriteLine("9) Bet on CORNERZ");
                Console.WriteLine("10)Bet on Zeros");
                Console.ForegroundColor = ConsoleColor.White;

                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 1:
                        Number n = new Number(this);
                        n.NumberBet();
                        break;
                    case 2:
                        EvenOdd e = new EvenOdd(this);
                        e.EvenOrOddBet();
                        break;
                    case 3:
                        RedBlack r = new RedBlack(this);
                        r.RedOrBlackbet();
                        break;
                    case 4:
                        LowHigh l = new LowHigh(this);
                        l.LowOrHighBet();
                        break;
                    case 5:
                        Dozens d = new Dozens(this);
                        d.DozensBet();
                        break;
                    case 6:
                        Columns c = new Columns(this);
                        c.ColumnsBet();
                        break;
                    case 7:
                        Streets s = new Streets(this);
                        s.StreetsBet();
                        break;
                    case 8:
                        Sixes x = new Sixes(this);
                        x.SetsOfSixBet();
                        break;
                    case 9:
                        Corners a = new Corners(this);
                        a.ConersBet();
                        break;
                    case 10:
                        Zero z = new Zero(this);
                        z.Zeros();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid bet");
                        break;

                }
                Console.WriteLine("Do you want to Bet again? y/n");
                var userInput = Console.ReadLine();
                if (userInput == "y")
                {
                    playAgain = true;
                }
                else if (userInput == "n")
                {
                    playAgain = false;
                }

            }
        }

    }

}
