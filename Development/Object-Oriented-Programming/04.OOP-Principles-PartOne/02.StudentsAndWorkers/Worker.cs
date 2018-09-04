// 	<copyright file=Worker.cs company="Business Management Systems Ltd.">
//		Copyright (c) 2018 All Rights Reserved
// 	</copyright>
// 	<author>Kosta.Kiryazov</author>
// 	<date>8/28/2018 9:44:02 AM</date>
// 	<summary>Class representing a Worker entity</summary>
namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class Worker : Human
    {
        public decimal WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / this.WorkHoursPerDay;
        }
    }
}