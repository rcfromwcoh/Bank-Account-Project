using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProject
{
    class SavingsAccount : Account
    {
        //Field 1


        //Field 2


        //Property 1


        //Property 2


        //Constructor 1
        private string jobTitle;
        private int money;
        private int hunger;
        private string name;

        //Properties
        public string JobTitle
        {
            get { return this.jobTitle; }
            set { this.jobTitle = value; }
        }
        public int Money
        {
            get { return this.money; }
            set { this.money = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //Constructors
        public SavingsAccount()
        {
            this.jobTitle = "Mechanic";
            this.money = 10000;
            this.hunger = 50;
            this.name = "Jane";
        }

        //Methods

        public void Raise()
        {
            money = money + 5000;
        }

        public void Eat()
        {
            hunger = hunger - 15;
            money = money - 2000;
        }

        public void PrintStats()
        {
            Console.WriteLine("Money: " + this.money);
            Console.WriteLine("Hunger: " + this.hunger);
        }

        public void Tick()
        {
            money = money - 1000;
            hunger = hunger + 5;
        }

    }
}
