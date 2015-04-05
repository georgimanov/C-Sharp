namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using WarMachines.Interfaces;


    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string name)
        {
            this.Name = name;
            this.machines = new List<IMachine>();
        }

        private ICollection<IMachine> Machines { get { return this.machines; } set { this.machines = new List<IMachine>();} } 

        public string Name
        {
            get { return this.name; }
            private set
            {
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder();

            report.Append(this.Name + " - ");
            if (this.machines.Count == 0)
            {
                return report.Append("no machines").ToString();
            }
            else if (this.machines.Count == 1)
            {
                report.AppendLine(this.machines.Count + " machine");
            }
            else
            {
                report.AppendLine(this.machines.Count + " machines");
            }

            foreach (var machine in this.machines.OrderBy(h => h.HealthPoints).ThenBy(n => n.Name))
            {
                report.AppendLine(machine.ToString());
            }

            return report.ToString().TrimEnd();
        }
    }
}
