using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Homework
{
    class Candy : BaseProperties
    {
        public Candy()
        {
            var randomValue = new Random();
            Price = randomValue.Next(1, 10);
            Quantity = randomValue.Next(1, 100);
            string[] randomName = { "Gummy-Bear", "Princas", "Saldi Pagunda", "Tinginys", "Nomeda", "Rikis", "Migle" };
            int nameIndex = randomValue.Next(6);
            Name = randomName[nameIndex];
            }
       
        public void List()
        {
            if (Quantity > 0)
            {
                Console.WriteLine($"Candy Name is {Name}");
                Console.WriteLine($"Candy Price is {Price}");
                Console.WriteLine($"Candy Quantity is {Quantity}\n");
            }
            else
            {
                Console.WriteLine("Sorry we run out off Stock come back later");
            }
        }
            
    }
}
