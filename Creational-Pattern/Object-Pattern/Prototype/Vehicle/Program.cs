using System;

namespace Prototype.Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {   
            // normal vehicle initialization
            VehicleManager manager = new VehicleManager();
            IVehicle saloon1 = manager.CreateSaloon();
            IVehicle saloon2 = manager.CreateSaloon();
            IVehicle pickup = manager.CreatePickup();
            
            // vehicle lazy initialization
            VehicleManagerLazy lazyManager = new VehicleManagerLazy();
            IVehicle saloon1Lazy = lazyManager.CreateSaloon();
            IVehicle saloon2Lazy = lazyManager.CreateSaloon();
            IVehicle pickupLazy = lazyManager.CreatePickup();

            // wait for user
            Console.Read();
        }
    }
}
