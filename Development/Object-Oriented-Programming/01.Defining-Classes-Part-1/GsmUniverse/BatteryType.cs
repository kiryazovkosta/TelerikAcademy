// <copyright file=BatteryType company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/5/2018 11:29:25 AM</date>
// <summary>Class representing a BatteryType entity</summary>

namespace GsmUniverse
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    public enum BatteryType
    {
        UnKnown,
        LiIon,
        NiMH,
        NiCd,
        ZiIo,
        SSB
    }
}