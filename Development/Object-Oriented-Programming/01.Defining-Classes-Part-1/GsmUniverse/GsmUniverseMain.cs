// <copyright file=GsmUniverseMain company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/5/2018 10:45:21 AM</date>
// <summary>Class representing a GsmUniverseMain entity</summary>

namespace GsmUniverse
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    public class GsmUniverseMain
    {
        public static void Main()
        {
            //var gsms = new List<Gsm>()
            //{
            //    new Gsm("Lumin 950", "Microsoft"),
            //    new Gsm("Xelo", "Sony", 123, "Kosta Andreev Kiryazov",
            //        new Battery("ZT44X", 400, 18, BatteryType.NiMH),
            //        new Display(5.5, uint.MaxValue / 2))
            //};
            //foreach (Gsm gsm in gsms)
            //{
            //    Console.WriteLine(gsm.ToString());
            //}

            //Console.WriteLine(Gsm.IPhone4S.ToString());

            GsmCallHistoryTest();
        }

        private static void GsmCallHistoryTest()
        {
            Gsm gsm = new Gsm("IPhone 8", "Apple", 1600.00M, "Kosta Kiryazov", new Battery(), new Display());
            gsm.AddCall(new Call("+3590899305031", 120));
            gsm.AddCall(new Call(DateTime.UtcNow.AddDays(-5),"+3590899305031", 12));
            gsm.AddCall(new Call(DateTime.UtcNow.AddDays(-3),"+3590899305031", 55));
            gsm.AddCall(new Call(DateTime.UtcNow.AddDays(-1),"+3590899305031", 300));
            gsm.AddCall(new Call("+3590899305031", 44));
            gsm.AddCall(new Call(DateTime.UtcNow.AddMinutes(-40),"+3590899305031", 60));
            gsm.PrintCallHistory();

            if (gsm.CallHoistory.Any())
            {
                decimal totalPrice = gsm.CalculateTotalCallPrice(0.37m);
                Console.WriteLine($"Total price for calls {totalPrice}");

                Call callWithLongestCall = null;
                foreach (Call call in gsm.CallHoistory)
                {
                    if (callWithLongestCall == null || call.Duration > callWithLongestCall.Duration)
                    {
                        callWithLongestCall = call;
                    }
                }

                gsm.RemoveCall(callWithLongestCall);
                gsm.PrintCallHistory();

                gsm.ClearCalls();
                gsm.PrintCallHistory();
            }

        }
    }
}