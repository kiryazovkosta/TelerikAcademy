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
            var gsm = new Gsm("Lumin 950", "Microsoft");
            Console.WriteLine(gsm.ToString());
            gsm.Price = 123;
            gsm.Owner = "Kosta Andreev Kiryazov";
            gsm.Battery = new Battery("ZT44X", 400, 18, BatteryType.NiMH);
            gsm.Display = new Display();
            gsm.Display.Size = 5.5;
            gsm.Display.NumberOfColors = uint.MaxValue / 2;
            Console.WriteLine(gsm);

        }
    }
}