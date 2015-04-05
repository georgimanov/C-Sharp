using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class EffectableSupplement : Supplement
    {
        protected bool hasEffect = false;

        public EffectableSupplement(int powerEffect, int healthEffect, int aggressionEffect) 
            : base(powerEffect, healthEffect, aggressionEffect)
        {
        }

        public override int AggressionEffect
        {
            get 
            { 
                if (!this.hasEffect)
                {
                    return 0;
                }

                return base.AggressionEffect;
            }
            protected set { base.AggressionEffect = value; }
        }

        public override int HealthEffect
        {
            get
            {
                if (!this.hasEffect)
                {
                    return 0;
                }

                return base.HealthEffect;
            }
            protected set { base.HealthEffect = value; }
        }

        public override int PowerEffect
        {
            get
            {
                if (!this.hasEffect)
                {
                    return 0;
                }

                return base.PowerEffect;
            }
            protected set { base.PowerEffect = value; }
        }
    }
}
