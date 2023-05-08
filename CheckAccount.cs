using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    internal class CheckAccount : BankAccount
    {
        //CheckingAccount(Inherit from BankAccount

        //Fields
        //overdraft fee (double )
        double _overdraftFee = 150.00; 

        //Constructor
        //Implement the base constructor, add parameter for overdraft fee
        public CheckAccount(string name, double overdraftFee) : base(name)
        {
            OverdraftFee = overdraftFee;
        }

        //Property
        //overdraftFee { get; set; }
        public double OverdraftFee { get => _overdraftFee; set => _overdraftFee = value; }

        public override void Deposit(double amount)
        {
            double addedMoney = amount += base.Balance; 

            if(base.Balance <= 0)
            {
                Console.WriteLine($"An overdraft fee was placed onto your account of {_overdraftFee}");
            }
        }

        //Method
        //override Withdraw(double amount) : If the withdraw fails, have it withdraw the overdraft fee from the _balance;



        //override ToString - Add fee to base.ToString()

        public override string ToString()
        {
            return $" You've been penalize with an Overdraft fee of {_overdraftFee}";
        }

        public override void Withdraw(double amount)
        {
            double remainingAmount = amount -= base.Balance; 
            if (base.Balance <= 0)
            {
                Console.WriteLine($"An overdraft fee was placed onto your account of {_overdraftFee}");
            }
        }
    }
}
