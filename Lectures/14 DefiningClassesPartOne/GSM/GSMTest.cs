namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    class GSMTest
    {
        static void Main()
        {
            Battery myBattery = new Battery("B. M.", 15, 56, BatteryType.NiMH);
            Battery myBattery1 = new Battery("B. M.", 17, 68, BatteryType.LiIon);
            Battery myBattery2 = new Battery("B. M.", 16, 69, BatteryType.NiCd);
            
            GSM gsm = new GSM("S6", "Samsung", 500.03m, "Pesho", myBattery);
            Console.WriteLine(gsm + "\n");
            Console.WriteLine(GSM.IPhone + "\n");

            GSM gsm1 = new GSM("S1", "Samsung", 100.09m, "Pesho", myBattery);
            GSM gsm2 = new GSM("S2", "Samsung", 200.09m, "Pesho", myBattery1);
            GSM gsm3 = new GSM("S3", "Samsung", 300.09m, "Pesho", myBattery2);
            GSM gsm4 = new GSM("S4", "Samsung", 400.09m, "Pesho", myBattery1);

            List<GSM> gsmList = new List<GSM>() { gsm1, gsm2, gsm3, gsm4 };

            foreach (var telephone in gsmList)
            {
                Console.WriteLine(telephone);
            }

            DateTime date1 = new DateTime(2008, 8, 29, 19, 27, 15, 18);
            DateTime date2 = new DateTime(2014, 8, 30, 19, 22, 15, 18);
            DateTime date3 = new DateTime(2014, 9, 15, 10, 12, 14, 44);

            CultureInfo ci = CultureInfo.InvariantCulture;

            Call call1 = new Call(date1, date1, "+359878864612", 120);
            Call call2 = new Call(date2, date2, "+359871164612", 820);
            Call call3 = new Call(date3, date3, "+359872264612", 320);
            
            gsm.AddCall(call1);
            gsm.AddCall(call2);
            gsm.AddCall(call3);

            var calls = gsm.GetCalls();

            gsm.DisplayCallsInfo();
            
            Console.WriteLine("\nTotal price of the calls in the history is {0} BGN\n", gsm.CallPrice());

            var longestCall = calls.OrderByDescending(x => x.CallDurationInSeconds).First();
            gsm.DeleteCall(longestCall);
            
            Console.WriteLine("Phone call deleted");
            Console.WriteLine("\nTotal price of the calls in the history is {0} BGN\n", gsm.CallPrice());

            gsm.ClearCallHistory();
            gsm.DisplayCallsInfo();
        }
    }
}
