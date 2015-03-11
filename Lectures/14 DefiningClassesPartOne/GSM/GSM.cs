namespace GSM
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private const decimal PRICE_PER_MINUTE = 0.37m;
        private List<Call> CallHistory;

        public static string IPhone
        {
            get
            {
                return "IPhone4S[Apple, Price: 1024, Owner: Bai Misho, Battery info [Super space battery]]";
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentNullException("GSM model cannot be null or empty");
                }
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentNullException("GSM manufacturer cannot be null or empty");
                }

                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative value");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value == String.Empty)
                {
                    throw new ArgumentNullException("Owner cannot be null or empty");
                }

                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public GSM()
        {
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
        }

        public override string ToString()
        {
            return new String('-', 50) + "\nGSM Info: \nModel: " + this.Model + ", \nManufacturer: " + this.Manufacturer + ", \nPrice: " + this.Price + ", \nOwner: " + this.Owner + ", \n" + this.Battery;
        }

        public void DisplayCallsInfo()
        {
            Console.WriteLine("{0}", new String('-', 50));
            Console.WriteLine("\nInformation for all the calls of:\n{0}\n", this );
            Console.WriteLine("{0}", new String('-', 50));
            if (this.CallHistory.Count != 0)
            {
                foreach (var call in this.CallHistory)
                {
                    Console.WriteLine("---");
                    Console.WriteLine("{0}", call);
                }
            }
            else
            {
                Console.WriteLine("-=Empty phone history=-");
                Console.WriteLine("{0}", new String('-', 50));

            }
            
            

        }
        public void AddCall(Call call)
        {
            if (this.CallHistory == null)
            {
                this.CallHistory = new List<Call>();
            }

            this.CallHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.CallHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.CallHistory.Clear();
        }

        public List<Call> GetCalls()
        {
            return this.CallHistory;
        }

        public decimal CallPrice()
        {
            ulong totalCallSeconds = 0;

            foreach (var call in CallHistory)
            {
                totalCallSeconds += call.CallDurationInSeconds;
            }

            ulong totalCallsMinutes = totalCallSeconds / 60;

            return totalCallsMinutes * PRICE_PER_MINUTE;
        }
    }
}