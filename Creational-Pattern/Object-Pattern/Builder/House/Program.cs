using System;

namespace Builder.House
{
    class Program
    {
        static void Main(string[] args)
        {
            HouseDirector director = new HouseDirector();
            HouseBuilder woodBuilder = new WoodBuilder();
            BrickBuilder brickBuilder = new BrickBuilder();

            // Build a wooden house
            House woodHouse = director.ConstructHouse(woodBuilder);
            
            Console.WriteLine();
            // Build a brick house
            House brickHouse = director.ConstructHouse(brickBuilder);
            
            // Wait for user
            Console.ReadLine();
        }
    }
}
