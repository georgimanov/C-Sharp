using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarMachines.Machines
{

    public static class Validator
    {
        public static bool NullOrEmptyCheck(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Value cannot be null or emtpy");
            }

            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Value canno be filled with white space only");
            }

            return true;
        }

        public static bool NegativeValueCheck(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be negative");
            }

            return true;
        }
    }
}
