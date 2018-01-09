// <copyright file=Display company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/5/2018 10:46:31 AM</date>
// <summary>Class representing a Display entity</summary>
namespace GsmUniverse
{
    #region Usings
    using System;
    #endregion

    public class Display
    {
        private const double DefaultSize = 4.0;
        private const uint DefaultNumberOfColors = uint.MaxValue;

        private double? size;

        public Display()
            : this(DefaultSize, DefaultNumberOfColors)
        {
        }

        public Display(double sizeParam, uint numberOfColorsParam )
        {
            this.Size = sizeParam;
            this.NumberOfColors = numberOfColorsParam;
        }

        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0.5 || value > 100.0)
                {
                    throw new ArgumentException(nameof(this.size));
                }

                this.size = value;
            }
        }

        public uint NumberOfColors { get; set; }
    }
}