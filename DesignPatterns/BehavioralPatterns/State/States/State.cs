using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    public abstract class State
    {
        protected State(Account account)
        {
            this.Account = account;
        }

        protected Account Account { get; private set; }

        protected decimal Interest { get; set; }

        protected decimal LowerLimit { get; set; }

        protected decimal UpperLimit { get; set; }

        public abstract void Deposit(decimal amount);

        public abstract void Withdraw(decimal amount);

        public abstract void PayInterest();
    }
}
