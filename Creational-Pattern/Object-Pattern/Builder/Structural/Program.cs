using System;

namespace Builder.Structural
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create one director and two builders
            Director director = new Director();

            IBuilder b1 = new Builder1();
            IBuilder b2 = new Builder2();

            // Construct two products
            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.Display();

            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.Display();  
            
            // Wait for user
            Console.ReadLine();
        }
    }
}
