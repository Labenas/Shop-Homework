using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Shop_Homework
{
    class Program
    {
        static void Main(string[] args)
        {   
            var list = new List();
            var cup = new Cup();
            list.PrintCommands();
            cup.List();
            int amountOfBuying=1;
            string pureString="a";
            do
            {

                    //getting command + value of items 
                    CommandPrep(ref amountOfBuying, ref pureString);

                    //Controler of Entry

                    if (pureString == "buycup" || pureString == "cupbuy")
                    {
                        cup.Quantity = Buy(cup.Quantity, amountOfBuying);
                        cup.List();
                        list.PrintCommandsShort();
                        Console.WriteLine("press Esc to quit console\n");
                    }
                    else
                    {
                        Console.WriteLine("Command you enter doesn't exist");
                        list.PrintCommandsShort();
                    }
                
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);



            
        }
        public static int Buy(int cupQuantity,int amountOfBuying)
        {
            int result = cupQuantity - amountOfBuying;
            return result;
        }
        public static void CommandPrep(ref int amountOfBuying,ref string pureString)
        {
            var isTrue = true;
           
            while (isTrue)
            {
                var command = Console.ReadLine().ToLower();

                string[] amountString = Regex.Split(command, @"[a-zA-Z!@#$%^&,.?:{}| \<>]");
                amountString = amountString.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                //getting pure string from entry
                string[] pureStringRemover = Regex.Split(command, @"[\d+!@#$%^&,.?:{}| \<>]");
                var pureStringRemoveEmpty = pureStringRemover.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                pureString = string.Join("", pureStringRemoveEmpty);

                if (!amountString.Any())
                {
                    Console.WriteLine("Missing amount of items you would like to buy");
                    break;
                }else
                {
                    amountOfBuying = Convert.ToInt32(amountString[0]);
                    isTrue = false;
                    
                }
            }
            

            
        }
        
       
    }
}
