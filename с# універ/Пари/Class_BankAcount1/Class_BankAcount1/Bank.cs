using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_BankAcount1
{
    class Human
    {
        private string name;
        public string Name
        {
            get { return name; }

        }
        public Human (string name)
        {
            this.name = name;
        }
        public void Print()
        {
            Console.WriteLine("name: " + name);
        }
    }
    class BankAccount
    {
        private Human owner;
        // static private double money=1000;
        private double money=1000;
        private double limit;

        public BankAccount(Human owner,double limit=300)
        {
            this.owner = owner;
            this.limit = limit;
        }
        public BankAccount() { }
        public double Money
        {
            get { return money; }
        }
        public double Limit
        {
            get { return limit; }
            set { limit = value; }
        }
        public void AddMoney(double addSum)
        {
            money += addSum;
        }
        public void TakeMoney(double takesum)
        {
            if ((takesum <= limit) && (money >= takesum))
            {
                money -= takesum;
            }
            else Console.WriteLine("You dont have enough money or exceeded yor limit. Money an not be taken!");
            
        }
        public void PrintInfo()
        {
            Console.WriteLine("Owner: {0}\nMoney: {1}", owner.Name, money);
        }

    }
}
