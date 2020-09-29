using System;
using System.Drawing;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal- DONE
            // give this class 4 members that all Animals have in common- DONE


            // Create a class Bird - DONE
            // give this class 4 members that are specific to Bird- DONE
            // Set this class to inherit from your Animal Class- DONE

            // Create a class Reptile- DONE
            // give this class 4 members that are specific to Reptile- DONE
            // Set this class to inherit from your Animal Class- DONE




            /*Create an object of your Bird class- DONE
             *  give values to your members using the object of your Bird class- DONE
             *  
             * Creatively display the class member values - DONE
             */

            var bigBird = new Bird();
            {
                bigBird.CanFly = true;
                bigBird.Talons = 2;
                bigBird.WingSpan = 7.3;
                bigBird.Color = "brown";

                /*Create an object of your Reptile class- DONE
           *  give values to your members using the object of your Bird class- DONE
           *  
           * Creatively display the class member values- DONE
           */
                var snake = new Reptile()
                {
                    HasScales = true,
                    Dwelling = "grass",
                    Size = 7.5,
                    SwallowsRodents = true
                };

                var theseAnimals = new Animal[] { bigBird, snake };
                foreach (var animal in theseAnimals)
                {
                    Console.WriteLine($"Is alive: {animal.IsAlive}");
                    Console.WriteLine($"Age: {animal.Age} years old");
                    Console.WriteLine($"It has {animal.LegCount} legs");
                    Console.WriteLine($"It lives on the {animal.Habitat}");
                }
                //Console.WriteLine(snake.Habitat);
                //Console.WriteLine(snake.HasScales);
                //Console.WriteLine(snake.SwallowsRodents);
                //Console.WriteLine(snake.LegCount);

            }
        }
    }
}
