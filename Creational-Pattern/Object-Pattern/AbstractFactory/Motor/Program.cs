using System;

namespace AbstractFactory.Motor;
{
    class Program
    {
        /// <summary>
        /// 'Client' Application
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            string whatToMake = "car"; // or "van"

            AbstractVehicleFactory factory = null;

            // Create the correct 'factory'...
            if (whatToMake.Equals("car"))
                factory = new CarFactory();
            else
                factory = new VanFactory();

            // Create the vehicle's component parts...
            // These will either be all car parts or all van parts
            IBody vehicleBody = factory.CreateBody();
            IChassis vehicleChassis = factory.CreateChassis();
            IGlassware vehicleGlassware = factory.CreateGlassware();

            // Show what we've created...
            Console.WriteLine(vehicleBody.BodyParts);
            Console.WriteLine(vehicleChassis.ChassisParts);
            Console.WriteLine(vehicleGlassware.GlasswareParts );
            Console.Read();
        }
    }
}
