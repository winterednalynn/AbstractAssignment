using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAssignment
{
    abstract class BankAccount
    {
        //BankAccount

        //FIELDS 

        string _name;
        int _accountNumber;
        double _balance;

        Random rand = new Random();

        //CONSTRUCTOR 
        public BankAccount(string name)
        {
            Name = name;

            _accountNumber = rand.Next(452548, 525465);
        }

        //Properties
        //Name
        //{ get; set; }
        //AccountNumber and Balance { get; }
        public string Name { get => _name; set => _name = value; }
        public int AccountNumber { get => _accountNumber; }
        public double Balance { get => _balance; }


        public abstract void Deposit(double amount); // ABSTRACT METHODS 


        public abstract void Withdraw(double amount); // ABSTRACT METHODS 


        //Override ToString
        //this.GetType() - Display Name - Account Number - Balance
        public override string ToString()
        {
            return this.GetType() + $"\n Name {_name}  - Account Number {_accountNumber} - Balance {_balance}";
        }

    }
}
