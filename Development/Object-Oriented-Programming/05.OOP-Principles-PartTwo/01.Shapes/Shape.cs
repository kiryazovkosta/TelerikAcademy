// 	<copyright file=Shape.cs company="Business Management Systems Ltd.">
//		Copyright (c) 2018 All Rights Reserved
// 	</copyright>
// 	<author>Kosta.Kiryazov</author>
// 	<date>8/29/2018 1:49:23 PM</date>
// 	<summary>Class representing a Shape entity</summary>
namespace _01.Shapes
{
    using System;

    public abstract class Shape
    {
        private double width;
        private double height;

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(nameof(this.width));
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(nameof(this.height));
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}