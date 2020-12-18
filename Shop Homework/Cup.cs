using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Homework
{   

    class Cup : Properties
    {
        public Cup()
        {
            var randomValue = new Random();
            Price = randomValue.Next(1, 10);
            Quantity = randomValue.Next(1, 100);
            string[] randomName = { "Juodberis", "Naktis", "Nabuchodosoras", "Rocket", "Wing", "Kuinas", "Lapas" };
            int nameIndex = randomValue.Next(6);
            Name = randomName[nameIndex];
            
        }
        public void List() 
        {
            if (Quantity>1) 
            { 
            Console.WriteLine($"\nCup Name is {Name}");
            Console.WriteLine($"Cup Price is {Price} ");
            Console.WriteLine($"Cup Quantity is {Quantity}");
            }
            else
            {
                Console.WriteLine("Sorry we run out off Stock come back later");
            }
        }
        public void CupUp(int CurrentQuantityCup, int IncreaseCupBy)
        {
            Quantity = CurrentQuantityCup + IncreaseCupBy;


        }
        public void PrintCommands()
        {
            Console.WriteLine("Aviable operations inside program: \n1) Buy ItemNAme + Quantity\n2) Balance up + Quantity \n3) Cup up + Quantity\nExample:\n\t\t Buy Cup 50\n\t\t List\n\t\t Balance up 100\n");
        }
        public void PrintCommandsShort()
        {
            Console.WriteLine("Aviable operations inside program: \n1) Buy ItemNAme + Quantity\n2) Balance up\n3) Key input ESC to quit\n");
        }
    }
}
