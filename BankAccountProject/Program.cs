using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankAccountProject
{
    class Program
    {
        static void Main(string[] args)
        {   //This is the Bank Account Project work for the We Can Code It Bootcamp
            //Robert Horrocks, August 4, 2016

            //You will be designing a console application to manage a client’s bank account. 
            //For now, the application will have only one client that is hard-coded into the system.


            //Tasks:

            //Using a user facing interface, it will pull information and display
            //Menu Items:

            //View Client Information
            //View Account Balance
            //Checking Account Balance
            //Reserve Account Balance
            //Savings Account Balance
            //Deposit Funds
            //Withdraw Funds
            //Exit


            //Checking Account Class

            // Inherits Account base class
            // Minimum 2 fields
            // Minimum 2 properties
            // Minimum 1 constructor

            //Reserve Account Class

            // Inherits Account base class
            // Minimum 2 fields
            // Minimum 2 properties
            // Minimum 1 constructor

            //Savings Account Class

            // Inherits Account base class
            // Minimum 2 fields
            // Minimum 2 properties
            // Minimum 1 constructor

            //Objects

            // Minimum 1 object instantiated from the Checking Account Class
            // Minimum 1 object instantiated from the Reserve Account Class
            // Minimum 1 object instantiated from the Savings Account Class

            //Other Requirements

            // Use StreamWriter to create account summary files that track transactions 
            //for each account type (each type has its own text file). 
            //Files should be located in the Debug Folder and should include:
            // Name of Client
            // Client Account Number
            // Account Type(Checking, Reserve, or Savings)
            // Each transaction should be on its own line
            // Each transaction should show date and time of transaction(must use DateTime Class)
            // Each transaction should show a “+” for deposit and a “-” for withdrawal
            // Each transaction should show the transaction amount
            // Each transaction should show the new current balance after the transaction

            double totalBalance = 0.0d;
            double checkingBalance = 0.0d;
            double reserveBalance = 0.0d;
            double savingsBalance = 0.0d;
            totalBalance = (checkingBalance + reserveBalance + savingsBalance);
            string clientInput = "0";
            
            //PrintStats();

            Account joeSmith = new Account();
            //joeSmith.PrintStats();
            CheckingAccount checkingUser = new CheckingAccount();

            StringBuilder mainMenu = new StringBuilder();
            mainMenu.Append("OurBank Main Menu\n");
            //joeSmith.PrintStats();
            //mainMenu.Append("Client Name: ");
            //mainMenu.Append(clientName+" \n");
            //mainMenu.Append("ID Number: ");
            //mainMenu.Append(clientIdNumber + "\n");
            mainMenu.Append("View Client Information, Press '1'\n");
            //mainMenu.Append("Total of All Account Balances: "+ totalBalance + "\n");
            mainMenu.Append("View Account Balance Information, Press '2'\n");
            //mainMenu.Append("Checking Account Balance: "+ checkingBalance + "\n");
            //mainMenu.Append("Reserve Account Balance: " + reserveBalance+ "\n");
            //mainMenu.Append("Savings Account Balance: " + savingsBalance + "\n");
            mainMenu.Append("To Deposit Funds, Press '3'\n");
            mainMenu.Append("To Withdraw Funds, Press '4'\n");
            mainMenu.Append("To Exit the Application, Press '5'\n");
            mainMenu.Append("Thank you for being a valued OurBank customer!\n");
            mainMenu.Append("Today's Date and time is: " + DateTime.Now + "\n");
            Console.WriteLine(mainMenu.ToString());
            joeSmith.PrintStats();
            clientInput = Console.ReadLine();
            if(clientInput == "1")
            {
                joeSmith.PrintClientInfo();
            }
            else if(clientInput == "2")
            {
                joeSmith.PrintStats();
            }
            else if(clientInput == "3")
            {
                joeSmith.PrintStats();
                joeSmith.Deposit();

            }
            else if(clientInput == "4")
            {
                Console.Clear();
                Console.WriteLine("Do you want to write a check (1), or withdrawl from savings (2)?");
                int userResponse = Convert.ToInt32(Console.ReadLine());
                if (userResponse == 1)
                    checkingUser.WriteCheck();
                else
                    joeSmith.Withdrawl();
            }
            Console.ReadKey();

            StreamWriter checkingWriter = new StreamWriter("checking.txt");
            using (checkingWriter){
            checkingWriter.Write("Hekki Wirld");
            }
            StreamWriter savingsWriter = new StreamWriter("savings.txt");
            using (savingsWriter)
            {
                savingsWriter.Write(DateTime.Now);
            }
            StreamWriter reserveWriter = new StreamWriter("reserve.txt");
            using (reserveWriter)
            {
                reserveWriter.Write(DateTime.Now);
            }
        }


    }
}
