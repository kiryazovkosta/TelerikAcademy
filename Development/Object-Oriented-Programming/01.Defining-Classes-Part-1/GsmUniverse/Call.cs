// <copyright file=Call company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/8/2018 1:25:36 PM</date>
// <summary>Class representing a Call entity</summary>

namespace GsmUniverse
{
    #region Usings
    using System;

    #endregion

    public class Call
    {
        private DateTime recordTimestamp;
        private string dialledPhoneNumber;
        private int duration;

        public Call(string dialledNumberParam, int durationParam)
            : this(DateTime.UtcNow, dialledNumberParam, durationParam)
        {
        }

        public Call(DateTime recordTimestampParam, string dialledNumberParam, int durationParam)
        {
            this.RecordTimestamp = recordTimestampParam;
            this.DialledPhoneNumber = dialledNumberParam;
            this.Duration = durationParam;
        }

        public DateTime RecordTimestamp
        {
            get
            {
                return this.recordTimestamp;
            }
            private set
            {
                if (value.CompareTo(DateTime.UtcNow) > 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.recordTimestamp));
                }

                this.recordTimestamp = value;
            }
        }

        public string DialledPhoneNumber
        {
            get
            {
                return this.dialledPhoneNumber;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(this.dialledPhoneNumber));
                }

                this.dialledPhoneNumber = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(nameof(duration));
                }

                this.duration = value;
            }
        }

        public override string ToString()
        {
            return $"DateTime[{this.RecordTimestamp.ToString("dd-MM-yyyy HH:mm:ss")}] Number[{this.DialledPhoneNumber}] Durration [{this.Duration}]";
        }
    }
}