// <copyright file=StringBuilderExtensions company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/11/2018 1:21:33 PM</date>
// <summary>Class representing a StringBuilderExtensions entity</summary>

namespace _01.StringBuilder.Substring
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    /// <summary>
    /// mplement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder 
    /// and has the same functionality as Substring in the class String.
    /// </summary>
    public static class StringBuilderExtensions
    {
        public static StringBuilder Substring(this StringBuilder input, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex >= input.Length)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            if ((startIndex + length) > input.Length)
            {
                throw new ArgumentException("Invalid length");
            }

            string value = input.ToString().Substring(startIndex, length);
            return new StringBuilder(value);
        }
    }
}