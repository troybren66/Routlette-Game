using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class RouletteBoard
    {

        public void Board()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" ________ ROULETTE________");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|   1    |   2    |    3  |-------");
            Console.WriteLine("|--------|--------|-------|       |");
            Console.WriteLine("|   4    |   5    |    6  |       |");
            Console.WriteLine("|--------|--------|-------|  1st  |");
            Console.WriteLine("|   7    |   8    |    9  | dozen |");
            Console.WriteLine("|--------|--------|-------|       |");
            Console.WriteLine("|   10   |   11   |   12  |       |");
            Console.WriteLine("|--------|--------|-------|-------");
            Console.WriteLine("|   13   |   14   |   15  |       |");
            Console.WriteLine("|--------|--------|-------|       |");
            Console.WriteLine("|   16   |   17   |   18  |       |");
            Console.WriteLine("|--------|--------|-------|  2nd  |");
            Console.WriteLine("|   19   |   20   |   21  | dozen |");
            Console.WriteLine("|--------|--------|-------|       |");
            Console.WriteLine("|   22   |   23   |   24  |       |");
            Console.WriteLine("|--------|--------|-------|--------");
            Console.WriteLine("|   25   |   26   |   27  |       |");
            Console.WriteLine("|--------|--------|-------|       |");
            Console.WriteLine("|   28   |   29   |   30  |  3rd  |");
            Console.WriteLine("|--------|--------|-------| dozen |");
            Console.WriteLine("|   31   |   32   |   33  |       |");
            Console.WriteLine("|--------|--------|-------|       |");
            Console.WriteLine("|___34___|___35___|___36__|_______|");


        }
    }
}
