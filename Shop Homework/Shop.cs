using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Shop_Homework
{
    class Shop
    {   
        public Shop()
        {
            
        }
        public  void Buy(int cupQuantity, int amountOfBuying,int Balance,int CupPrice,ref int newBalance,ref int newCupQuantity)
        {
           
            int wantToBuy = amountOfBuying * CupPrice;
            

            if (wantToBuy>Balance)
            {
                Console.WriteLine($"You want to buy more than you can! Add more into your account using Add\n");
            }
            else if(cupQuantity - amountOfBuying < 0)
            {
                Console.WriteLine("\t\t\tYou want buy more than we can offer at the moment.Sorry.\n");
                newBalance = Balance;
                newCupQuantity = cupQuantity;
            }
            else
            {
                newBalance = Balance - wantToBuy;
                newCupQuantity = cupQuantity - amountOfBuying;
            }
            

        }
        public  void CommandPrep(ref int amountOfBuying, ref string pureString)
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
                    Console.WriteLine("\t\t\tMissing entry amount of items you would like to buy\n\n");
                    break;
                }
                else
                {
                    amountOfBuying = Convert.ToInt32(amountString[0]);
                    isTrue = false;

                }
            }



        }
        public  void EvaluationOfQuantities()
        {

        }
      
    }
    
}
