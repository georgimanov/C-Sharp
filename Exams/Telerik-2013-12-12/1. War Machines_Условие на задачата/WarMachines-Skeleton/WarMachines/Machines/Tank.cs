using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Tank : Machine, ITank
    {
        private const double initialHealpoints = 100;
        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, Tank.initialHealpoints)
        {
            this.DefenseMode = true;
        }
        
        public bool DefenseMode { get; private set ; }

        public override double AttackPoints
        {
            get
            {
                if (this.DefenseMode)
                {
                    return this.attackPoints - 40;
                }

                return this.attackPoints;
            }
        }

        public override double DefensePoints
        {
            get
            {
                if (this.DefenseMode)
                {
                    return this.defensePoints + 30;
                }

                return this.defensePoints;
            }
            set { base.DefensePoints = value; }
        }

        public void ToggleDefenseMode()
        {
            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            return base.ToString() + 
                Environment.NewLine + 
                string.Format(" *Defense: {0}", this.DefenseMode ? "ON" : "OFF");
        }
    }
}
