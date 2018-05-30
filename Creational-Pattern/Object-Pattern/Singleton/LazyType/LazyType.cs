using System;

namespace Singleton.LazyType
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
        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());

        public static Singleton GetInstance
        {
            get
            {
                return lazy.Value;
            }
        }

        private Singleton() { }
    }
}
