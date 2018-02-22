using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Pet
{
    // Base class that serves as type to be instantiated for factory method pattern
    // IPet: Product class
    public interface IPet
    {
        string PetSound();
    }

    // Derived class 1 that might get instantiated by a factory method pattern
    // Dog: ConcreteProduct class
    public class Dog: IPet
    {
        public string PetSound()
        {
            return "Bow Bow...";
        }
    }

    // Derived class 2 that might get instantiated by a factory method pattern
    // Cat: ConcreteProduct class
    public class Cat : IPet
    {
        public string PetSound()
        {
            return "Meaw Meaw...";
        }
    }

    // Factory method pattern implementation that instantiates objects based on logic
    public class PetFactory
    {
        IPet _pet = null;
        
        public IPet GetPet(string petType)
        {
            // based on logic factory instantiates an object
            if (petType.Equals("Bow"))
                _pet = new Dog();
            else if (petType.Equals("Meaw"))
                _pet = new Cat();
            return _pet;
        }
    }
}
