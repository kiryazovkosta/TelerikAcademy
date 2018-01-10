// <copyright file=PathStorage company="Business Management Systems Ltd">
//   Copyright (c) 2018 All Rights Reserved
// </copyright>
// <author>Kosta Kiryazov</author>
// <date>1/10/2018 4:22:22 PM</date>
// <summary>Class representing a PathStorage entity</summary>

namespace StructurePoint3D
{
	#region Usings
	using System;
	using System.Collections.Generic;
    using System.IO;
    using System.Text;

    #endregion

    /// <summary>
    /// Create a static class PathStorage with static methods to save and load paths from a text file.
    /// Use a file format of your choice.
    /// </summary>
    public static class PathStorage
    {
        private const int ValidSize = 3;
        private static char[] separators = new char[] { '[', ']', ';' };

        public static void Save(Path path, string fileName)
        {
            using (var writer = new StreamWriter(fileName))
            {
                foreach (Point3D point in path.Points)
                {
                    writer.WriteLine(point.ToString());
                }
            }
        }

        public static Path Load(string fileName)
        {
            var path = new Path();
            using (var reader = new StreamReader(fileName))
            {
                var lineCounter = 0;
                var line = reader.ReadLine();
                while (line != null)
                {
                    lineCounter++;
                    var dimensions = Array.ConvertAll(line.Trim().Split(separators, StringSplitOptions.RemoveEmptyEntries), float.Parse);
                    if (dimensions.Length != ValidSize)
                    {
                        throw new IndexOutOfRangeException($"Invalid point at line {lineCounter}");
                    }

                    path.Add(new Point3D(dimensions[0], dimensions[1], dimensions[2]));
                    line = reader.ReadLine();
                }
            }

            return path;
        }
    }
}