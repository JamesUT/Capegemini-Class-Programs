using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo2
{
    class Customer
    {
        public int Balance { get; set; }

        public Customer(int balance)
        {
            Balance = balance;
        }

        public void Withdraw(int amount)
        {
            string message = "";

            if (Balance > amount)
            {
                Balance = Balance - amount;
                message = ("After deducting " + amount + "remaining balance is " + Balance);
            }
            else
            {
                message = "You are trying to withdraw a grater amount.";
            }

            Bank b = new Bank();
            b.BankEvent += SMSGateway.SendMessage;
            b.Notify(message);
        }
    }
}
