// <copyright file=Path company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/10/2018 4:14:54 PM</date>
// <summary>Class representing a Path entity</summary>

namespace StructurePoint3D
{
	#region Usings
	using System;
	using System.Collections.Generic;
	using System.Text;

    #endregion

    /// <summary>
    /// Create a class Path to hold a sequence of points in the 3D space.
    /// </summary>
    public class Path
    {
        private ICollection<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>(); 
        }

        public ICollection<Point3D> Points
        {
            get
            {
                return this.points;
            }
            private set
            {
                this.points = value;
            }
        }

        public void Add(Point3D point)
        {
            this.Points.Add(point);
        }
    }
}