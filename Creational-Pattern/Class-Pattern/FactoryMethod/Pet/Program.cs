using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Pet
{
    class Program
    {
        static void Main(string[] args)
        {
            PetFactory factory = new PetFactory();  // creating factory
            IPet pet = factory.GetPet("Bow");       // factory instantiates an object
            // you don't know which object factory created
            Console.WriteLine(pet.PetSound());
            Console.ReadKey();
        }
    }
}
