using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Shop_Homework
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int amountOfBuying = 0;
            string pureString = "a";
            int newBalance=0;
            int newCupQuantity=0;

            var cup = new Cup();
            var shop = new Shop();
            var user = new User();

            cup.PrintCommands();
            cup.List();
            user.ShowBalance();
            do
            {
                    shop.CommandPrep(ref amountOfBuying, ref pureString);
                    
                    if (pureString == "buycup" || pureString == "cupbuy")
                    {
                        shop.Buy(cup.Quantity, amountOfBuying,user.Balance,cup.Price,ref newBalance,ref newCupQuantity);
                        cup.Quantity = newCupQuantity;
                        user.Balance = newBalance;
                        cup.List();
                        user.ShowBalance();
                        cup.PrintCommandsShort();
                        Console.WriteLine("press Esc to quit console\n");
                    }
                    else if(pureString=="balanceup" || pureString == "upbalance")
                    {
                        user.BalanceUp(user.Balance,amountOfBuying);
                        cup.List();
                        user.ShowBalance();
                        cup.PrintCommandsShort();
                     }
                    else{
                        Console.WriteLine("\t\t\t\tCommand you enter doesn't exist\n");
                        cup.PrintCommandsShort();
                    }
                
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
