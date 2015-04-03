using System;

namespace FurnitureManufacturer.Models
{
    public static class Validator
    {
        public static bool CheckNullOrEmpty(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new NullReferenceException("Parameter cannot be null");
            }

            return true;
        }

        public static bool CheckLenght(string input, int lenght, bool exact)
        {
            if (input.Length != lenght && exact)
            {
                var exceptionMessage = string.Format("Parameter must be exactly {0} long", lenght);
                throw new ArgumentException(exceptionMessage);
            }

            if (input.Length < lenght && !exact)
            {
                var exceptionMessage = string.Format("Parameter must be minimum {0} chars long", lenght);
                throw new ArgumentException(exceptionMessage);
            }

            return true;
        }

        public static bool DigitsOnly(string input)
        {
            foreach (var symbol in input)
            {
                if (!Char.IsDigit(symbol))
                {
                    throw new ArgumentException("Parameter should contain only digits");
                }
            }

            return true;
        }

        public static bool NotNegativeNumber(decimal number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException("Value cannot be negative");
            }

            return true;
        }
    }
}