using System;

namespace Singleton.DoubleCheckedLocking
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
        private static volatile Singleton _instance =null;
        private static readonly object InstanceLock = new object();

        private Singleton() { }

        public static Singleton GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    lock (InstanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
