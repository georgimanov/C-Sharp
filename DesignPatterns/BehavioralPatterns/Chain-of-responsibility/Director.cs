using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    public class Director : PurchaseApprover
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000)
            {
                Console.WriteLine("{0} approved purchase with amount ${2} for {1}", this.GetType().Name, purchase.Purpose, purchase.Amount);
            }
            else
            {
                Console.WriteLine(
                   "Amounts greater than ${0} requires an executive meeting!",
                   purchase.Amount);
            }
        }
    }
}
