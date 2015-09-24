using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamLead = new TeamLead();
            var manager = new Manager();
            var director = new Director();

            teamLead.SetSuccessor(manager);
            manager.SetSuccessor(director);

            var purchase = new Purchase(350.00, "Monitor 24 inches");
            teamLead.ProcessRequest(purchase);

            purchase = new Purchase(2090.10, "Teambuilding weekend");
            teamLead.ProcessRequest(purchase);

            purchase = new Purchase(9500.00, "Super cool server");
            teamLead.ProcessRequest(purchase);

            purchase = new Purchase(55500.00, "Rent for the office for 2016");
            teamLead.ProcessRequest(purchase);
        }
    }
}
