using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication3
{


    class Program
    {
        static void Main(string[] args)
        {

            Human owner1 = new Human("Vasyl");
            //owner1.Print();
            
            BankAccount account1 = new BankAccount(owner1,10);
           // double addMoney = Convert.ToInt32(Console.ReadLine());
            //account1.Limit = 100;
           // account1.AddMoney(addMoney);
            
            account1.PrintInfo();
        }
    }
}

