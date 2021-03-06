﻿// <copyright file=Battery company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/5/2018 11:02:39 AM</date>
// <summary>Class representing a Battery entity</summary>

namespace GsmUniverse
{
    #region Usings
    using System;
    #endregion

    public class Battery
    {
        private string model;

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

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public ushort IdleHours { get; set; }

        public ushort TalkHours { get; set; }

        public BatteryType BatteryType { get; set; }
    }
}