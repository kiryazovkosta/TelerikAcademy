// 	<copyright file=Human.cs company="Business Management Systems Ltd.">
//		Copyright (c) $year All Rights Reserved
// 	</copyright>
// 	<author>Kosta.Kiryazov</author>
// 	<date>8/28/2018 9:15:03 AM</date>
// 	<summary>Class representing a Human entity</summary>
namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}