using System;

namespace Builder.Car
{
    class Program
    {
        /// <summary>
        /// 'Client' Application
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            var builder = new FerrariBuilder();
            var director = new SportsCarBuildDirector(builder);

            director.Construct();
            Car myRaceCar = builder.GetResult();
            Console.WriteLine("{0} constructed with \nMake: {1}\nModel: {2}\nColor: {3}\nDoors : {4}",
                myRaceCar.GetType().Name, myRaceCar.Make, myRaceCar.Model, myRaceCar.Color, myRaceCar.NumDoors);
            Console.Read();
        }
    }
 }
