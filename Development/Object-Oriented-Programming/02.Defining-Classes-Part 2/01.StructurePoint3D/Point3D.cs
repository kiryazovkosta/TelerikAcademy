// <copyright file=Point3D company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/9/2018 4:38:24 PM</date>
// <summary>Class representing a Point3D entity</summary>

namespace StructurePoint3D
{
	#region Usings
	using System;
	using System.Collections.Generic;
	using System.Text;

    #endregion

    /// <summary>
    /// Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
    /// Implement the ToString() to enable printing a 3D point.
    /// Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
    /// Add a static property to return the point O.
    /// </summary>
    public struct Point3D
    {
        private const string OutputFormatter = "F2";

        private static readonly Point3D zero = new Point3D(0, 0, 0);

        public Point3D(float xParam, float yParam, float zParam)
        {
            this.X = xParam;
            this.Y = yParam;
            this.Z = zParam;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public static Point3D Zero
        {
            get
            {
                return zero; 
            }
        } 

        public override string ToString()
        {
            return $"[{this.X.ToString(OutputFormatter)};{this.Y.ToString(OutputFormatter)};{this.Z.ToString(OutputFormatter)}]";
        }
    }
}