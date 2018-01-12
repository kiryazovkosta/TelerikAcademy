// <copyright file=IEnumerableExtensions company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/11/2018 2:13:11 PM</date>
// <summary>Class representing a IEnumerableExtensions entity</summary>

namespace _02.IEnumerableExtensions
{
    #region Usings
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    #endregion

    /// <summary>
    /// Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
    /// </summary>
    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> elements)
            where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
        {
            if (elements.IsNullOrEmpty())
            {
                throw new ArgumentException("Null or empty collection");
            }

            T sum = default(T);
            foreach (T item in elements)
            {
                sum += (dynamic)item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> elements)
            where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
        {
            if (elements.IsNullOrEmpty())
            {
                throw new ArgumentException("Null or empty collection");
            }

            T product = (dynamic)1;
            foreach (T item in elements)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> elements)
            where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
        {
            if (elements.IsNullOrEmpty())
            {
                throw new ArgumentException("Null or empty collection");
            }

            T min = elements.First();
            foreach (T item in elements)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> elements)
            where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
        {
            if (elements.IsNullOrEmpty())
            {
                throw new ArgumentException("Null or empty collection");
            }

            T max = elements.First();
            foreach (T item in elements)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }
            return max;
        }

        public static double Avg<T>(this IEnumerable<T> elements)
            where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
        {
            if (elements.IsNullOrEmpty())
            {
                throw new ArgumentException("Null or empty collection");
            }

            T sum = elements.Sum();
            return (dynamic)sum / elements.Count();
        }

        public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
        {
            if (source != null)
            {
                foreach (T obj in source)
                {
                    return false;
                }
            }
            return true;
        }
    }
}