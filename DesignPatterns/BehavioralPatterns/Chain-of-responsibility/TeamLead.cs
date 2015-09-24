using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    class TeamLead : PurchaseApprover
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 500)
            {
                Console.WriteLine("{0} approved purchase with amount ${2} for {1}", this.GetType().Name, purchase.Purpose, purchase.Amount);
            }
            else if (this.Successor != null)
            {
                this.Successor.ProcessRequest(purchase);
            }
        }
    }
}
