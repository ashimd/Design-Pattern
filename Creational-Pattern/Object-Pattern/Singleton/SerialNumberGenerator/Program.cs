using System;

namespace Singleton.SerialNumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("next serial: " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial: " + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial: " + SerialNumberGenerator.Instance.NextSerial);

            Console.Read();
        }
    }
}
