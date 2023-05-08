using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    internal class RetirementAccount:SavingAccount
    {
        //RetirementAccount : Inherit from SavingsAccount
        public RetirementAccount(string name) : base(name)
        {
        }



        //Method
        //new Withdraw : return false and Display a Message "Cannot withdraw from a retirement account"

        public new bool Withdraw(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Cannot withdraw from a retirement account");
            }
            return false;

        }
    }
}
