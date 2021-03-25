using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird Tucano = new Bird()
            {
                Name = "Brasa",
                Age = 65,
                Hasbackbone = false,
                HasFeathers = true,
                Legs = 2,
                Type = "Extravagant",
                FlyorNot = true,
                Wings = 2
            };

            Console.WriteLine($"{Tucano.Name} is {Tucano.Age} years old and has {Tucano.Legs} legs and {Tucano.Wings} wings being of type {Tucano.Type} and it` is found more in the South American continent");
            Console.WriteLine($"Does {Tucano.Name} has back bones, feathers and Fly?" + $" {Tucano.Hasbackbone}, {Tucano.HasFeathers} and {Tucano.FlyorNot}");
            Console.WriteLine();
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Reptile Coral = new Reptile()
            {
                Name = "Nocalsocs",
                Age = 39,
                Hasbackbone = false,
                HasLegs = false,
                HasScales = true,
                IsColdBlooded = false,
                Environment = "Tropical Forest"

            };

            Console.WriteLine($"{Coral.Name} is {Coral.Age}, and it`s usually found in the {Coral.Environment}");
            Console.WriteLine($"Do {Coral.Name} have legs, scales, back bones ans is cold blooded?" + $"{ Coral.HasLegs}, { Coral.HasScales}, { Coral.Hasbackbone} and { Coral.IsColdBlooded} It`s not Cold Blooded!");
            Console.WriteLine();
        }
    }
}
