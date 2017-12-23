﻿namespace _06.StringsandObjects
{
    using System;

    /// <summary>
    /// Declare two string variables and assign them with  Hello  and  World . 
    /// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). 
    /// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
    /// </summary>
    public class StringsAndObjects
    {
        public static void Main()
        {
            string helloText = "Hello";
            string worldText = "World";
            object message = helloText + " " + worldText;
            string greeting = (string)message;
            Console.WriteLine(message);
        }
    }
}
