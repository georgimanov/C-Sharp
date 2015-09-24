using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account("Pesho Peshev");

            account.Deposit(500.0m);
            account.Deposit(300.0m);
            account.Deposit(550.0m);
            account.PayInterest();
            account.Withdraw(1000.00m);
            // try unreal situation
            account.Withdraw(1100.00m);
        }
    }
}
