using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Shop_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfBuying = 1;
            string pureString = "a";

            var cup = new Cup();
            var shop = new Shop();

            cup.PrintCommands();
            cup.List();

            do
            {
                    shop.CommandPrep(ref amountOfBuying, ref pureString);

                    if (pureString == "buycup" || pureString == "cupbuy")
                    {
                        cup.Quantity = shop.Buy(cup.Quantity, amountOfBuying);
                        cup.List();
                        cup.PrintCommandsShort();
                        Console.WriteLine("press Esc to quit console\n");
                    }
                    else
                    {
                        Console.WriteLine("Command you enter doesn't exist");
                        cup.PrintCommandsShort();
                    }
                
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
