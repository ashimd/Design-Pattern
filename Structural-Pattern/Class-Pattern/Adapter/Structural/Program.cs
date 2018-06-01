using System;

namespace Adapter.Structural
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Showing the Adaptee in standalone mode
            Adaptee first = new Adaptee();
            Console.WriteLine("Before the new standard\nPrecise reading: ");
            Console.WriteLine(first.SpecificRequest(5, 3));

            //// What the client really wants
            ITarget second = new Adapter();
            Console.WriteLine("\nMoving to the new tandard");
            Console.WriteLine(second.Request(5));            

            // Wait for the user
            Console.Read();
        }
    }
}
