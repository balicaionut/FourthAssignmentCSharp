using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthAssignmentCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("--- Animal exercise -----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();

            Animal animal1 = new Animal();
            animal1.typeAnimal = "caine";
            animal1.color = "negru";
            animal1.age = 3;
            Console.WriteLine();
            Console.WriteLine("Tip: " + animal1.typeAnimal + "\nCuloare: " + animal1.color + "\nVarsta: " + animal1.age);

            Animal animal2 = new Animal("pisica");
            animal1.color = "alb";
            animal1.age = 6;
            Console.WriteLine();
            Console.WriteLine("Tip: " + animal2.typeAnimal + "\nCuloare: " + animal2.color + "\nVarsta: " + animal2.age);

            Animal animal3 = new Animal("hamster", "roscat", 1);
            Console.WriteLine();
            Console.WriteLine("Tip: " + animal3.typeAnimal + "\nCuloare: " + animal3.color + "\nVarsta: " + animal3.age);
            
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");

            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("--- House exercise -----------------------------------");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
            Console.WriteLine();



            Console.WriteLine();
            Console.WriteLine("Press any key to continue! ;)");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("--- Bonus :) -----------------------------------");
            Console.WriteLine();
                       


            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();
        }
    }
}
