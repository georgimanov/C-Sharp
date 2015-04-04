
namespace WarMachines.Machines
{
    using System.Collections.Generic;
    using System.Text;

    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        protected double attackPoints;
        protected double defensePoints;
        private double healthPoints;
        private IList<string> targets;

        protected Machine(string name, double attackPoints, double defensePoints, double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.HealthPoints = healthPoints;
            this.targets = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.NullOrEmptyCheck(value);
                this.name = value;
            }
        }


        public IPilot Pilot { get; set; }

        public double HealthPoints
        {
            get { return this.healthPoints; }
            set
            {
                Validator.NegativeValueCheck(value);
                this.healthPoints = value;
            }
        }

        public virtual double AttackPoints
        {
            get { return this.attackPoints; }
            set
            {
                Validator.NegativeValueCheck(value);
                this.attackPoints = value;
            }
        }

        public virtual double DefensePoints
        {
            get { return this.defensePoints; }
            set
            {
                Validator.NegativeValueCheck(value);
                this.defensePoints = value;
            }
        }

        public IList<string> Targets 
        {
            get
            {
                return new List<string>(this.targets);
            }
        }

        public virtual void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(string.Format("- {0}", this.Name));
            sb.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            sb.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            sb.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            sb.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            sb.AppendLine(string.Format(" *Targets: {0}", (this.Targets.Count > 0 ? string.Join(", ", this.Targets) : "None")));

            return sb.ToString().Trim();
        }
    }
}
