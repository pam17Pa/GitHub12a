﻿using System;

namespace GitExercise
{
    public static class OptionsManager
    {
        //Coment add...
        public static string[] OptionsList = {
            "a - Add",
            "s - Subtract",
            "m - Multiply",
            "d - Divide"
        };

        public static void Add(double a, double b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} x {b} = {a * b}");
        }

        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = {a - b}");
        }
        public static void Divide(double a, double b)
        {
            Console.WriteLine($"{a} / {b} = {a / b}");
        }
    }
}
