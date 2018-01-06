// <copyright file=Battery company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/5/2018 11:02:39 AM</date>
// <summary>Class representing a Battery entity</summary>

namespace GsmUniverse
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    public class Battery
    {
        public string Model { get; set; }

        public ushort IdleHours { get; set; }

        public ushort TalkHours { get; set; }

        public BatteryType BatteryType { get; set; }

        public Battery()
            : this(null, 0, 0, BatteryType.UnKnown)
        {
        }

        public Battery(string modelParam, ushort idleParam, ushort talkParam, BatteryType batteryTypeParam)
        {
            this.Model = modelParam;
            this.IdleHours = idleParam;
            this.TalkHours = talkParam;
            this.BatteryType = batteryTypeParam;
        }
    }
}