using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Shop_Homework
{
    class Shop
    {   public Shop()
        {

        }
        public  int Buy(int cupQuantity, int amountOfBuying)
        {
            int result = cupQuantity - amountOfBuying;
            return result;
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
                    Console.WriteLine("Missing amount of items you would like to buy");
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
