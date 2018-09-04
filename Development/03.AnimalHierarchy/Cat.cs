// 	<copyright file=Cat.cs company="Business Management Systems Ltd.">
//		Copyright (c) 2018 All Rights Reserved
// 	</copyright>
// 	<author>Kosta.Kiryazov</author>
// 	<date>8/28/2018 2:09:38 PM</date>
// 	<summary>Class representing a Cat entity</summary>
namespace _03.AnimalHierarchy
{
    using System;

    public class Cat : Animal
    {
        public Cat(int ageParam, string nameParam, SexType sexTypeParam)
            : base(ageParam, nameParam, sexTypeParam)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cat");
        }
    }
}