using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    using State.States;

    public class Account
    {
        public Account(string owner)
        {
            this.Owner = owner;
            this.State = new BaseState(this);
        }

        public decimal Balance { get; set; }

        public string Owner { get; set; }

        public State State { get; set; }

        public void Deposit(decimal amount)
        {
            this.State.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            this.PrintStatus();
        }

        public void Withdraw(decimal amount)
        {
            this.State.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            this.PrintStatus();
        }

        public void PayInterest()
        {
            this.State.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            this.PrintStatus();
        }

        private void PrintStatus()
        {
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status  = {0}", this.State.GetType().Name);
            Console.WriteLine();
        }
    }
}
