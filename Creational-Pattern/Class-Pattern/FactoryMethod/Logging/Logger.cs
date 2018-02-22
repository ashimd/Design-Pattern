using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Logging
{
    public interface AppLogger
    {
        void Log(string logMsg);
    }

    public class FileLogger : AppLogger
    {
        public void Log(string logMsg)
        {
            System.IO.File.WriteAllText("Logging.txt", logMsg);
        }
    }

    public class DatabaseLogger : AppLogger
    {
        public void Log(string logMsg)
        {
            // Open Database Connection
            // Write log to it
        }
    }

    public class ConsoleLogger : AppLogger
    {
        public void Log(string logMsg)
        {
            Console.WriteLine(logMsg);
        }
    }

    public class LoggerFactory
    {
        AppLogger _logger = null;
        // Factory Method
        public AppLogger GetLogger(int value)
        {
            switch (value)
            {
                case 1:
                   _logger= new FileLogger();
                   break;
                case 2:
                   _logger = new DatabaseLogger();
                   break;
                case 3:
                   _logger = new ConsoleLogger();
                   break;
                default:
                    break;
            }
            return _logger;
        }
    }
}
