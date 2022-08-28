using System;

namespace CarExerciseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var personalCar = new Car
            {
                Make = "Infiniti",
                Model = "Q50",
                Year = 2015
            };

            Console.WriteLine($"{personalCar.Year} {personalCar.Make} {personalCar.Model}");
        }
    }
}
