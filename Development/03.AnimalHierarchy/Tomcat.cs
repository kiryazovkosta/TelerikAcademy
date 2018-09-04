// 	<copyright file=Tomcat.cs company="Business Management Systems Ltd.">
//		Copyright (c) 2018 All Rights Reserved
// 	</copyright>
// 	<author>Kosta.Kiryazov</author>
// 	<date>8/28/2018 2:29:46 PM</date>
// 	<summary>Class representing a Tomcat entity</summary>
namespace _03.AnimalHierarchy
{
    using System;
    public class Tomcat : Cat
    {
        public Tomcat(int ageParam, string nameParam, SexType sexTypeParam)
            : base(ageParam, nameParam, SexType.Male)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Tomcat");
        }
    }
}