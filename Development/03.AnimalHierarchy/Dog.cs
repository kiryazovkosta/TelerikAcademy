// 	<copyright file=Dog.cs company="Business Management Systems Ltd.">
//		Copyright (c) 2018 All Rights Reserved
// 	</copyright>
// 	<author>Kosta.Kiryazov</author>
// 	<date>8/28/2018 2:07:12 PM</date>
// 	<summary>Class representing a Dog entity</summary>
namespace _03.AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        public Dog(int ageParam, string nameParam, SexType sexTypeParam)
            :base(ageParam, nameParam, sexTypeParam)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("Dog");
        }
    }
}