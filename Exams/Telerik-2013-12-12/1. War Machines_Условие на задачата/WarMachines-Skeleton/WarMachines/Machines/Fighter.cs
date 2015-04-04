using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WarMachines.Interfaces;

namespace WarMachines.Machines
{
    public class Fighter : Machine, IFighter
    {
        private const double initialHealthPoints = 200;
        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base (name, attackPoints, defensePoints, Fighter.initialHealthPoints)
        {
            this.StealthMode = stealthMode;
        }
        
        public bool StealthMode { get ; private set; }
        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }
        public override string ToString()
        {
            return base.ToString() +
                Environment.NewLine +
                string.Format(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF");
        }
    }
}
