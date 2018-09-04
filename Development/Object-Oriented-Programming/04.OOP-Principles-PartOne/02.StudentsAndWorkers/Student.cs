// 	<copyright file=Student.cs company="Business Management Systems Ltd.">
//		Copyright (c) 2018 All Rights Reserved
// 	</copyright>
// 	<author>Kosta.Kiryazov</author>
// 	<date>8/28/2018 9:43:02 AM</date>
// 	<summary>Class representing a Student entity</summary>
namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Student : Human
    {
        public int Grade { get; set; }
    }
}