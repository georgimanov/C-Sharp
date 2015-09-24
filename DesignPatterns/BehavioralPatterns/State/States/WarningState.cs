using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class WarningState : State
    {
        public WarningState(Account account)
            : base(account)
        {
            this.Interest = 0.0m;
            this.LowerLimit = -100.0m;
            this.UpperLimit = 0.0m;
        }

        public override void Deposit(decimal amount)
        {
            this.Account.Balance += amount;
            if (this.Account.Balance > this.UpperLimit)
            {
                this.Account.State = new BaseState(this.Account);
            }
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine("No funds available for withdrawal!");
        }

        public override void PayInterest()
        {
            // NOPE!
        }
    }
}
