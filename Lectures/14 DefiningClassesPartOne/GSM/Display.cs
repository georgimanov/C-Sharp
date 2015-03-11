namespace GSM
{
    using System;
    public class Display
    {
        private decimal size;
        private ulong numberOfColors;

        public decimal Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Size cannot be negative value");
                }

                this.size = value;
            }
        }

        public ulong NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Number of colors cannot be negative value");
                }

                this.numberOfColors = value;
            }
        }

        public Display(decimal size, ulong numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        } 

    }
}
