using System;

namespace Singleton.Multithreaded
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

    /// <summary>
    /// The 'Singleton' Class
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object Instancelock = new object();

        private Singleton() { }

        public static Singleton GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }
    }
}
