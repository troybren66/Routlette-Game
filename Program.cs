using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Roulette! Feeling lucky, punk? \nLets find out!");
            RouletteBoard r = new RouletteBoard();
            r.Board();
            Menu B = new Menu();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Starting Amount: $5,000");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What do you want to do? (Choose one)");
            B.playerMenu();

        }

    }
}
