using System;

namespace Builder.Brand
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Client twice
            new Client<Poochy>().ClientMain();
            new Client<Gucci>().ClientMain();
            
            // Wait for user
            Console.ReadLine();
        }
    }
}
