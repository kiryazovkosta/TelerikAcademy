// 	<copyright file=Animal.cs company="Business Management Systems Ltd.">
//		Copyright (c) 2018 All Rights Reserved
// 	</copyright>
// 	<author>Kosta.Kiryazov</author>
// 	<date>8/28/2018 2:00:12 PM</date>
// 	<summary>Class representing a Animal entity</summary>
namespace _03.AnimalHierarchy
{
    using System;

    public abstract class Animal : ISound
    {
        private readonly int age;
        private readonly string name;
        private readonly SexType sex;

        public Animal(int ageParam, string nameParam, SexType sexTypeParam)
        {
            if (ageParam < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(ageParam));
            }

            this.age = ageParam;
            this.name = nameParam;
            this.sex = sexTypeParam;
        }

        public int Age { get => this.age; }
        public string Name { get => this.name; }
        public SexType Sex { get; set; }

        public abstract void ProduceSound();
    }
}