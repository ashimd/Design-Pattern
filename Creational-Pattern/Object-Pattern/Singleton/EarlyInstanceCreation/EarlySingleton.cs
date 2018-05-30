using System;

namespace Singleton.EarlyInstanceCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Constructor is protected -- cannot use new
            EarlySingleton s1 = EarlySingleton.GetInstance();
            EarlySingleton s2 = EarlySingleton.GetInstance();

            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            // Wait for user
            Console.ReadKey();
        }
    }

    public class EarlySingleton
    {
        private static EarlySingleton instance = new EarlySingleton();

        private EarlySingleton() { }

        public static EarlySingleton GetInstance()
        {
            return instance;
        }
    }
}
