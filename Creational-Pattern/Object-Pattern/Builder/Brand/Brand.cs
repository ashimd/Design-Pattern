using System;
using System.Threading;

// Builder Pattern D-J Miller and Judith Bishop Sept 2007

// Abstract Factory : Builder Implementation

namespace BuilderPattern
{
    /// <summary>
    /// The 'Product' Signature
    /// </summary>
    interface IBag
    {
        string Properties { get; set; }
    }

    /// <summary>
    /// The 'Concrete Product' Class
    /// </summary>
    /// <seealso cref="BuilderPattern.IBag" />
    class Bag : IBag
    {
        public string Properties { get; set; }
    }
    
    /// <summary>
    /// The 'Builder' Task Signature
    /// </summary>
    /// <typeparam name="Brand">The type of the brand.</typeparam>
    interface IBuilder<Brand>
        where Brand : IBrand
    {
        IBag CreateBag();
    }

    // Abstract Factory now the Builder
    class Builder<Brand> : IBuilder<Brand>
        where Brand : IBrand, new()
    {
        Brand myBrand;

        public Builder()
        {
            myBrand = new Brand();
        }

        public IBag CreateBag()
        {
            return myBrand.CreateBag();
        }
    }    

    // Directors
    /// <summary>
    /// The 'Director' Signature
    /// </summary>
    interface IBrand
    {
        IBag CreateBag();
    }

    /// <summary>
    /// The 'Director' Class
    /// </summary>
    /// <seealso cref="BuilderPattern.IBrand" />
    class Gucci : IBrand
    {

        public IBag CreateBag()
        {
            Bag b = new Bag();
            Process.DoWork("Cut Leather", 250);
            Process.DoWork("Sew Leather", 1000);
            b.Properties += "Leather";
            Process.DoWork("Create Lining", 500);
            Process.DoWork("Attach Lining", 1000);
            b.Properties += " lined";
            Process.DoWork("Add Label", 250);
            b.Properties += " with label";
            return b;
        }
    }

    /// <summary>
    /// The 'Director' Class
    /// </summary>
    /// <seealso cref="BuilderPattern.IBrand" />
    class Poochy : IBrand
    {

        public IBag CreateBag()
        {
            Bag b = new Bag();
            Process.DoWork("Hire cheap labour", 200);
            Process.DoWork("Cut Plastic", 125);
            Process.DoWork("Sew Plastic", 500);
            b.Properties += "Plastic";
            Process.DoWork("Add Label", 100);
            b.Properties += " with label";
            return b;
        }
    }

    /// <summary>
    /// The 'Client' Implementation
    /// </summary>
    /// <typeparam name="Brand">The type of the rand.</typeparam>
    class Client<Brand>
        where Brand : IBrand, new()
    {
        public void ClientMain() // IFactory<Brand> factory)
        {
            IBuilder<Brand> factory = new Builder<Brand>();
            DateTime date = DateTime.Now;
            Console.WriteLine("I want to buy a bag!");
            IBag bag = factory.CreateBag();

            Console.WriteLine("I got my Bag which took " +
                DateTime.Now.Subtract(date).TotalSeconds * 5 + " days");
            Console.WriteLine(" with the following properties \n" +
                bag.Properties + "\n");
        }
    }

    /// <summary>
    /// The 'Process' Class
    /// </summary>
    static class Process
    {
        public static void DoWork(string workitem, int time)
        {
            Console.WriteLine();
            Console.Write("" + workitem + ": 0%");
            Thread.Sleep(time);
            Console.Write("....25%");
            Thread.Sleep(time);
            Console.Write("....50%");
            Thread.Sleep(time);
            Console.Write("....100%");
            Console.WriteLine();
        }
    }
}
