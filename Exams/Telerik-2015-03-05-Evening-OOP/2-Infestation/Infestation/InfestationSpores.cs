using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class InfestationSpores : EffectableSupplement
    {
        public InfestationSpores() 
            : base(-1, 0, 20)
        {
            this.hasEffect = true;
        }

        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is InfestationSpores)
            {
                this.hasEffect = false;
            }
        }
    }
}
