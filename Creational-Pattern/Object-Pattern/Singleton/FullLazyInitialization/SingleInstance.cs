using System;

namespace Singleton.FullLazyInstantiation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor is protected -- cannot use new
            Singleton s1 = Singleton.GetInstance;
            Singleton s2 = Singleton.GetInstance;

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    public sealed class Singleton
    {
        private Singleton() { }

        public static Singleton GetInstance
        {
            get
            {
                return GetSingleInstance.instance;
            }
        }

        private class GetSingleInstance
        {
            static GetSingleInstance() { }

            internal static readonly Singleton instance = new Singleton();
        }        
    }
}
