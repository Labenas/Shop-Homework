using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Homework
{   

    class Cup : BaseProperties
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
            Console.WriteLine($"Cup Name is {Name}");
            Console.WriteLine($"Cup Price is {Price} ");
            Console.WriteLine($"Cup Quantity is {Quantity}\n");
            }
            else
            {
                Console.WriteLine("Sorry we run out off Stock come back later");
            }
        }
    }
}
