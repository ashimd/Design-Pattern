using System;

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
            
            pet = petFactory.GetPet("Meaw");       // factory instantiates another object
            Console.WriteLine(pet.PetSound());
            Console.ReadLine();
        }
    }
}
