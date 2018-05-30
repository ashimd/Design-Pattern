
namespace Singleton.Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericSingleton<SimpleType> instance = new GenericSingleton<SimpleType>();
            SimpleType simple = instance.GetInstance();
        }
    }

    public class SimpleType{}

    public class GenericSingleton<T> where T : new()
    {
        private static T m_StaticInstance = new T();

        public T GetInstance()
        {
            return m_StaticInstance;
        }
    }
}
