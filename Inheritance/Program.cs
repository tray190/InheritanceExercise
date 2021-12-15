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

            Bird COCO = new Bird();
            {
               COCO.Name = "COCO";
                COCO.Age = 100;
                COCO.Talons = 8;
                COCO.Wings = "to fly";
                COCO.Beak = "to crack open shells";
                COCO.IsWarmBlooded = true;


                Console.WriteLine($" I have a bird name {COCO.Name} she is {COCO.Age} has {COCO.Talons} talons she uses her wings {COCO.Wings},  is she warm blooded? {COCO.IsWarmBlooded}");
                Console.ReadLine();
            }
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile Reptar = new Reptile();

            Reptar.Name = "Reptar";
            Reptar.Age = 50;
            Reptar.Scales = "wouuld have dry skin and scales";
            Reptar.amnioteEgg = 3;
            Reptar.MetanephricKidney = 2;
            Reptar.IsColdBlooded = true;

            Console.WriteLine($"I have a reptile name {Reptar.Name} he is {Reptar.Age} years old would have {Reptar.Scales} {Reptar.amnioteEgg} eggs {Reptar.MetanephricKidney} Kidney and he is cold blooded {Reptar.IsColdBlooded}");
            Console.ReadLine();
        }
    }
}
