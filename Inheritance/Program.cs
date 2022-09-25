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

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Bird bird1 = new Bird();
            bird1.feet = 2;
            bird1.wings = 3;
            bird1.voice = "ded";
            bird1.flyingHeight = 22;
            bird1.ears = 2;
            bird1.color = "brown";
            bird1.eyes = 2;
            bird1.name = "eagle";
            Console.WriteLine($"{bird1.name},{bird1.feet},{bird1.wings},{bird1.color},{bird1.ears},{bird1.voice}," +
                $"{bird1.flyingHeight},{bird1.eyes}");
            Console.WriteLine("-----------");
            Reptile reptile1 = new Reptile();
            reptile1.weight = 2;
            reptile1.backbone = 3;
            reptile1.skinColor = "dark grey";
            reptile1.eyeColor = "red";
            reptile1.ears = 2;
            reptile1.color = "brown";
            reptile1.eyes = 2;
            reptile1.name = "snake";
            Console.WriteLine(reptile1.ears);
            Console.WriteLine(reptile1.color);
            Console.WriteLine(reptile1.eyes);
            Console.WriteLine(reptile1.name);


        }
    }
}
