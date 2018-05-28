using System;

namespace Builder.CarPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder builder = new HighEndCarBuilder();
            MechanicalEngineer engineer = new MechanicalEngineer(builder);
            engineer.BuildCar();
            Car highEndCar = engineer.GetCar();
            Console.WriteLine("{0} Used Builder ({1}) to construct {2}", engineer.GetType().Name, builder.GetType().Name, highEndCar.GetType().Name);
            Console.WriteLine("With Attributes : \n{0}", highEndCar.Properties);

            Console.WriteLine();

            builder = new LowPriceCarBuilder();            
            engineer = new MechanicalEngineer(builder);
            engineer.BuildCar();
            Car lowPricedCar = engineer.GetCar();
            Console.WriteLine("{0} Used Builder ({1}) to construct {2}", engineer.GetType().Name, builder.GetType().Name, lowPricedCar.GetType().Name);
            Console.WriteLine("With Attributes : \n{0}", lowPricedCar.Properties);
            
            // Wait for user
            Console.ReadLine();
        }
    }
}
