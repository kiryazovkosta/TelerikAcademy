// <copyright file=Distance company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/9/2018 4:49:56 PM</date>
// <summary>Class representing a Distance entity</summary>

namespace StructurePoint3D
{
	#region Usings
	using System;
	using System.Collections.Generic;
	using System.Text;
	
	#endregion 

    public static class Distance
    {
        public static float Calculate(Point3D firstPoint, Point3D secondPoint)
        {
            float distX = (float)Math.Pow(secondPoint.X - firstPoint.X, 2);
            float distY = (float)Math.Pow(secondPoint.Y - firstPoint.Y, 2);
            float distZ = (float)Math.Pow(secondPoint.Z - firstPoint.Z, 2);
        }
    }
}