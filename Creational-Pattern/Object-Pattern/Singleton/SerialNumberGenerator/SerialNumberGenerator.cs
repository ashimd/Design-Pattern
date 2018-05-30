namespace Singleton.SerialNumberGenerator
{
    public class SerialNumberGenerator
    {
        // static members
        private static volatile SerialNumberGenerator instance;

        public static SerialNumberGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SerialNumberGenerator();
                }
                return instance;
            }
        }

        // instance variables
        private int count;

        // private constructor
        private SerialNumberGenerator() { }

        // instance methods
        public virtual int NextSerial
        {
            get
            {
                return ++count;
            }
        }
    }
}
