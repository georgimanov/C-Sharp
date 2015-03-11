namespace GSM
{
    using System;

    public class Battery
    {
        private string model;
        private float hoursIdel;
        private float hoursTalk;
        private BatteryType type;
        
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException("Battery model cannot be an empty value");
                }

                this.model = value;
            }
        }


        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public float HoursIdel
        {
            get
            {
                return this.hoursIdel;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours idle cannot be negative value");
                }

                this.hoursIdel = value;
            }
        }

        public float HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours talk cannot be negative value");
                }

                this.hoursTalk = value;
            }
        }

        public Battery(string model)
        {
            this.Model = model;
        }

        public Battery(string model, float hoursIdle, float hoursTalk, BatteryType batteryType)
            : this(model)
        {
            this.HoursIdel = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = batteryType;
        }

        public override string ToString()
        {
            return "Battery info: \nModel: " + this.Model + ", \nHours Idel: " + this.HoursIdel + ", \nHours Talk: " + this.HoursTalk + ", \nBattery type: " + this.Type + "";
        }
    }
}
