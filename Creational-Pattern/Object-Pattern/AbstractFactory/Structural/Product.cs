namespace AbstractFactory.Structural
{
    /// <summary>
    /// The 'AbstractFactory' abstract class
    /// </summary>
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    /// <summary>
    /// The Concrete Implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.Structural.AbstractFactory" />
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    /// <summary>
    /// The Concrete Implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.Structural.AbstractFactory" />
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    /// <summary>
    /// The 'AbstractProduct' abstract class
    /// </summary>
    abstract class AbstractProductA { }

    /// <summary>
    /// The 'AbstractProduct' abstract class
    /// </summary>
    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    /// <summary>
    /// The 'Concrete' Implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.Structural.AbstractProductA" />
    class ProductA1 : AbstractProductA { }

    /// <summary>
    /// The 'Concrete' Implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.Structural.AbstractProductB" />
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    /// <summary>
    /// The 'Concrete' Implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.Structural.AbstractProductA" />
    class ProductA2 : AbstractProductA { }

    /// <summary>
    /// The 'Concrete' Implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.Structural.AbstractProductB" />
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    /// <summary>
    /// The 'Client' class
    /// </summary>
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        public Client(AbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}
