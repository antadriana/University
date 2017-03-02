using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_BankAcount1
{
    class Program
    {
        static void Main(string[] args)
        {
            Human owner1 = new Human("tato");
            BankAccount account1 = new BankAccount(owner1);
            account1.AddMoney(1500);
            account1.TakeMoney(2145);
            account1.PrintInfo();
            BankAccount account2 = new BankAccount();
            account2 = account1;
            account2.PrintInfo();
            account2.AddMoney(400);
            account2.PrintInfo();
            account1.PrintInfo();
            
        }
    }
}
