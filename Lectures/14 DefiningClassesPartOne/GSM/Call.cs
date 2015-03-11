namespace GSM
{
    using System;
    using System.Collections.Generic;

    public class Call
    {
        private DateTime date;
        private DateTime time;
        private string dialedPhone;
        private ulong callDurationInSeconds;

        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        public DateTime Time
        {
            get
            {
                return this.time;
            }
            set
            {
                this.time = value;
            }
        }

        public string DialedPhone
        {
            get
            {
                return this.dialedPhone;
            }
            set
            {
                this.dialedPhone = value;
            }
        }
        public ulong CallDurationInSeconds
        {
            get
            {
                return this.callDurationInSeconds;
            }
            set
            {
                this.callDurationInSeconds = value;
            }
        }

        public Call(DateTime date, DateTime time, string dialedPhone, ulong callDurationInSeconds)
        {
            this.Date = date;
            this.Time = time;
            this.DialedPhone = dialedPhone;
            this.CallDurationInSeconds = callDurationInSeconds;
        }

        public override string ToString()
        {
            return "Date: " + this.Date + ", Time: " + this.Time + ", Dialed phone: " + this.dialedPhone + ", Call duration: " + this.CallDurationInSeconds + " seconds";
        }
    }
}
