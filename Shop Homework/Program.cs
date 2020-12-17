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
            cup.PrintCommands();
            cup.List();

            
            

            do
            {

                    //getting command + value of items 
                    Shop.CommandPrep(ref amountOfBuying, ref pureString);
                   
                    //Controler of Entry

                    if (pureString == "buycup" || pureString == "cupbuy")
                    {
                        cup.Quantity = Shop.Buy(cup.Quantity, amountOfBuying);
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
