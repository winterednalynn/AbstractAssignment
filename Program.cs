using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{//EDNA LYNN LAXA 
//PROGRAMMING III 
//ABSTRACT 
//MAY 7 , 2023 
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a savings, checking, and retirement account✔

            // Saving them all to a list of accounts✔

           
            CheckAccount CA = new CheckAccount("Peach", 100);
            SavingAccount SA = new SavingAccount("Peach");
            RetirementAccount RA = new RetirementAccount("Peach");

            // Deposit 500 in to all accounts
          
            CA.Deposit(500);
            SA.Deposit(500);
            RA.Deposit(500);

            // Deposit - 50000 into all accounts
          
            CA.Deposit(-5000);
            SA.Deposit(-5000);
            RA.Deposit(-5000);

            // Withdraw 200 from all accounts
            
            CA.Withdraw(200);
            SA.Withdraw(200);
            RA.Withdraw(200);

            // Withdraw - 200000
            //  from all accounts
          
            CA.Withdraw(-200000);
            SA.Withdraw(-200000);
            RA.Withdraw(-200000);

            //Try to overdraw each account
            //Display results(You can do this all from a single loop to make your life much easier. Organize your variables and method calls to do this efficiently)
           
            Console.WriteLine(CA.ToString());
            Console.WriteLine(SA.ToString());
        }
    }
}
