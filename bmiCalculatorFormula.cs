using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections;
namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gender: (Male / Female): ");
            var gender = Console.ReadLine();
            Console.Write("Weight(kg): ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Height(meters): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double powHeight = Math.Pow(height, 2);
            double bmi = weight / powHeight;
            double roundBmi = Convert.ToDouble(Math.Round(bmi));
            Console.WriteLine("BMI: {0}", roundBmi);

            if(bmi <= 18.4)
            Console.WriteLine("Underweight");
            else if(18.5 <= bmi ||  bmi <= 24.9)
            Console.WriteLine("Normal");
            else if(25.0 <= bmi || bmi <= 39.9)
            Console.WriteLine("Overweight");
            else if(bmi >= 40.0)
            Console.WriteLine("Obese");
        }         
    }
}

