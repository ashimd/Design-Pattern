using System;

namespace Adapter.PhoneAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var microUsbRecharger = new MicroUsbRecharger();
            var iPhoneRecharger = new IPhoneRecharger();
            var androidRecharger = new AndroidRecharger();

            // Wait for the user
            Console.Read();        
        }
}
