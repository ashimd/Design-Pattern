using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Logging
{
    class Program
    {
        static void Main(string[] args)
        {
            LoggerFactory factory = new LoggerFactory();
            AppLogger logger = factory.GetLogger(1);
            logger.Log("Message To File");
            logger = factory.GetLogger(3);
            logger.Log("Console Message");
            Console.ReadKey();
        }
    }
}
