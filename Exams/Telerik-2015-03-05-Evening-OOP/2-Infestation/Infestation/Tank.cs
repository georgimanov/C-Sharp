using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    //TODO: Extract constants
    public class Tank : Unit
    {
        public Tank(string id) 
            : base(id, UnitClassification.Mechanical, 20, 25, 25)
        {
        }
    }
}
