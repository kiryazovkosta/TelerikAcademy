// 	<copyright file=Frog.cs company="Business Management Systems Ltd.">
//		Copyright (c) 2018 All Rights Reserved
// 	</copyright>
// 	<author>Kosta.Kiryazov</author>
// 	<date>8/28/2018 2:08:11 PM</date>
// 	<summary>Class representing a Frog entity</summary>
namespace _03.AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        public Frog(int ageParam, string nameParam, SexType sexTypeParam)
            : base(ageParam, nameParam, sexTypeParam)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Frog");
        }
    }
}