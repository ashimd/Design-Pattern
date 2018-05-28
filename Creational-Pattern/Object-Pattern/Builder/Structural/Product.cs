using System;
using System.Collections.Generic;

// Builder Pattern
// Simple theory code with one director and two builders
namespace Builder.Structural
{
    /// <summary>
    /// Builder uses a complex series of steps
    /// The 'Director' class
    /// </summary>
    class Director
    {        
        // Build a Product from several parts
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartB();
        }
    }

    /// <summary>
    /// The 'Builder' interface
    /// </summary>
    interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        Product GetResult();
    }

    /// <summary>
    /// The 'ConcreteBuilder' class
    /// </summary>
    /// <seealso cref="Builder.IBuilder" />
    class Builder1 : IBuilder
    {
        private Product product = new Product();

        public void BuildPartA()
        {
            product.Add("Part A ");
        }

        public void BuildPartB()
        {
            product.Add("Part B ");
        }

        public Product GetResult()
        {
            return product;
        }
    }

    /// <summary>
    /// The 'ConcreteBuilder' class
    /// </summary>
    /// <seealso cref="Builder.IBuilder" />
    class Builder2 : IBuilder
    {
        private Product product = new Product();

        public void BuildPartA()
        {
            product.Add("Part X ");
        }

        public void BuildPartB()
        {
            product.Add("Part Y ");
        }

        public Product GetResult()
        {
            return product;
        }
    }

    /// <summary>
    /// The 'Product' class
    /// </summary>
    class Product
    {
        List<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Display()
        {
            Console.WriteLine("\nProducts Parts -------");
            foreach (string part in parts)
                Console.Write(part);
            Console.WriteLine();
        }
    }
}
