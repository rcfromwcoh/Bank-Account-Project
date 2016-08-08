using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class CheckingAccount : Account
    {
        //Checks will go here (Withdrawal Method)
        //ATM Withdrawls
        //Point of Sale Debit Purchases
        //ACH Withdrawls








        //Constructor 1


        // Fields 

        private int checkingAccountNumber;
        private double checkingAccountBalance;


        //Properties

        public int CheckingAccountNumber
        {
            get { return this.checkingAccountNumber; }
            set { this.checkingAccountNumber = value; }
        }
        public double CheckingAccountBalance
        {
            get { return this.checkingAccountBalance; }
            set { this.checkingAccountBalance = value; }
        }


        //Constructors
        public CheckingAccount()
        {

            this.checkingAccountNumber = 234567;
            this.checkingAccountBalance = 5000;

        }

        //Methods

        public void WriteCheck()
        {
            Console.WriteLine("What is the check number you want to write?");
            int checkNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much is the check in dollars and cents?");
            double checkAmount = Convert.ToDouble(Console.ReadLine());


        }

        public void Eat()
        {
            //hunger = hunger - 15;
            //money = money - 2000;
        }

        public void PrintCheckingStats()
        {
            Console.WriteLine("Checking Balance: " + this.checkingAccountBalance);
            //Console.WriteLine("Hunger: " + this.hunger);
        }

        public void Tick()
        {
            //money = money - 1000;
            //hunger = hunger + 5;
        }

        StreamWriter writer = new StreamWriter("checking.txt");
 
        //{	
        //console.WriteLine(“Hello World”);
    //}
        
    }
}
