using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public class BaseState : State
    {
        public BaseState(Account account)
            : base(account)
        {
            this.Interest = 0.0m;
            this.LowerLimit = 0.0m;
            this.UpperLimit = 1000.0m;
        }
        
        public override void Deposit(decimal amount)
        {
            this.Account.Balance += amount;
            if (this.Account.Balance > this.UpperLimit)
            {
                this.Account.State = new BetterState(this.Account);
            }
        }

        public override void Withdraw(decimal amount)
        {
            if (amount + 100 >= this.Account.Balance)
            {
                Console.WriteLine("Bank can credit you only 100лв.!");
                Console.WriteLine();
                return;
            }
            this.Account.Balance -= amount;
            if (this.Account.Balance < this.LowerLimit)
            {
                this.Account.State = new WarningState(this.Account);
            }
        }

        public override void PayInterest()
        {
            this.Account.Balance += this.Interest * this.Account.Balance;
            if (this.Account.Balance > this.UpperLimit)
            {
                this.Account.State = new BetterState(this.Account);
            }
        }
    }
}
