// 	<copyright file=Kitten.cs company="Business Management Systems Ltd.">
//		Copyright (c) 2018 All Rights Reserved
// 	</copyright>
// 	<author>Kosta.Kiryazov</author>
// 	<date>8/28/2018 2:28:51 PM</date>
// 	<summary>Class representing a Kitten entity</summary>
namespace _03.AnimalHierarchy
{
    using System;

    public class Kitten : Cat, ISound
    {
        public Kitten(int ageParam, string nameParam)
            : base(ageParam, nameParam, SexType.Female)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kitten");
        }
    }
}