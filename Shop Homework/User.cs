using System;
using System.Collections.Generic;
using System.Text;

namespace Shop_Homework
{
    

    class User
    {
        public int Balance { get; set; }
        public User()
        {
            var randomValue = new Random();
            Balance = randomValue.Next(10, 100);
        }
        public void ShowBalance()
        {
            Console.WriteLine($"Your current Account Balance: {Balance}\n");
        }
        public void BalanceUp(int CurrentBalance,int IncreaseBy)
        {
            Balance = CurrentBalance + IncreaseBy;
            
            
        }
       
    }
}

