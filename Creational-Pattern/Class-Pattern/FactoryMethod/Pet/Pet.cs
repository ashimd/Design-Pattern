namespace FactoryMethod.Pet
{
    /// <summary>
    /// Base class that serves as type to be instantiated for factory method pattern
    /// IPet: Product class
    /// </summary>
    public interface IPet
    {
        string PetSound();
    }

    /// <summary>
    /// Derived class 1 that might get instantiated by a factory method pattern
    /// Dog: ConcreteProduct class
    /// </summary>
    /// <seealso cref="FactoryMethod.IPet" />
    public class Dog : IPet
    {
        public string PetSound()
        {
            return "Bow Bow ...";
        }
    }

    /// <summary>
    /// Derived class 2 that might get instantiated by a factory method pattern
    /// Cat: ConcreteProduct class
    /// </summary>
    /// <seealso cref="FactoryMethod.IPet" />
    public class Cat : IPet
    {
        public string PetSound()
        {
            return "Meaw Meaw";
        }
    }
    
    /// <summary>
    /// Factory method pattern implementation that instantiates objects based on logic     
    /// </summary>
    public class PetFactory
    {
        IPet _pet = null;

        public IPet GetPet(string petType)
        {
            if (petType == "Bow")
                _pet = new Dog();
            else if (petType == "Meaw")
                _pet = new Cat();
            else
                return _pet;

            return _pet;
        }
    }
}
