using System;

namespace Singleton.Structural
{
    class Program
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            // Constructor is protected -- cannot use new
            Singleton s1 = Singleton.Instance;
            Singleton s2 = Singleton.Instance;

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Singleton' class
    /// </summary>
    sealed class Singleton
    {
        private static Singleton _instance = new Singleton();

        // Constructor is 'private'
        private Singleton() { }

        public static Singleton Instance { get { return _instance; } }
    }
}
