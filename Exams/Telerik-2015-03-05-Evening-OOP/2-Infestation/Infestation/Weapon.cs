using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Weapon : EffectableSupplement
    {
        public Weapon() 
            : base(10, 0, 3)
        {
            this.hasEffect = false;
        }


        public override void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.hasEffect = true;
            }
        }
    }
}
