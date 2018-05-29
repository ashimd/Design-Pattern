using System;

namespace AbstractFactory.Gui
{
    /// <summary>
    /// The 'Client' Application
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var appearance = Settings.Appearance;

            IGuiFactory factory;
            switch (appearance)
            {
                case Settings.Appear.Osx:
                    factory = new WinFactory();
                    break;
                case Settings.Appear.Win:
                    factory = new OsxFactory();
                    break;
                default:
                    break;
            }

            Console.Read();
        }
    }
}
