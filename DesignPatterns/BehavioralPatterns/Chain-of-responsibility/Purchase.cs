using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    public class Purchase
    {
        public Purchase(double amount, string purpose)
        {
            this.Amount = amount;
            this.Purpose = purpose;
        }

        public double Amount { get; set; }

        public string Purpose { get; set; }
    }
}
