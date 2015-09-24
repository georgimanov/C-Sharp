using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    public abstract class PurchaseApprover
    {
        protected PurchaseApprover Successor { get; set; }

        public void SetSuccessor(PurchaseApprover successor)
        {
            this.Successor = successor;
        }

        public abstract void ProcessRequest(Purchase purchase);
    }
}
