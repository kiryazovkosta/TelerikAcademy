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
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    public class Display
    {
        public double? Size { get; set; }

        public uint NumberOfColors { get; set; }

        public Display()
            : this(4.0, uint.MaxValue)
        {
        }

        public Display(double sizeParam, uint numberOfColorsParam )
        {
            this.Size = sizeParam;
            this.NumberOfColors = numberOfColorsParam;
        }
    }
}