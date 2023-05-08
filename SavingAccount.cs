using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    internal class SavingAccount : BankAccount
    {
        //SavingsAccount

        //Fields
        //interest(double )
        double _interest = 100;

        //Constructor
        //Using the base constructor and add the interest parameter
        public SavingAccount(string name) : base(name)
        {

        }

        //Property
        //interest
        //{ get; set; }
        public double Interest { get => _interest; set => _interest = value; }

        //Method
        //override Deposit : If deposit is successful add interest to the account
        //override ToString: Add Interest to base.ToString();

        public override void Deposit(double amount)
        {
            _interest += amount;
            Console.WriteLine($"Thank you for your Deposit, an interest amount of was added {_interest}");
        }

        public override string ToString()
        {
            return $"An Interest amount was added to your Saving Account of {_interest} \n" + base.ToString();
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine($"An amount - {amount} was withdrawn from Saving Account");

            if (base.Balance <= 0)
            {
                Console.WriteLine("You do not have these funds");
            }
        }
    }
}
