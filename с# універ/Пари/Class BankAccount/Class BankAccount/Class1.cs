using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{

    class Human
    {
        string name;

        public Human(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get;
            set;
        }
        public void Print()
        {
            Console.WriteLine("name: {0}", name);
        }

    }
    class BankAccount
    {

        static double money = 100;
            double limit;
        Human owner;

        public BankAccount(Human owner, double limit = 10)
        {
            this.owner = owner;
            //this.money = money;
            this.limit = limit;

        }
       


        public void AddMoney(double addsum)
        {
            money += addsum;
        }

        public void TakeMoney(double takesum)
        {
            money -= takesum;
        }
        public Human Owner
        {
            get { return owner; }
            
        }
      /*  public double Money
        {
            get { return money; }

        }*/
        public double Limit
        {
            get
            {
                return limit;
            }
            set
            {
                limit = value;
            }
        }
       /* public void CalcTheNewSumOfMoney(double money=0)
        {
            this.money = money;


        }*/
        public void PrintInfo()
        {
            Console.WriteLine("Owner: {0}\nThe amount of money: {1}\n", owner);
        }

    }
}
