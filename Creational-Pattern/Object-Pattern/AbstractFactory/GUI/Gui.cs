namespace AbstractFactory.Gui
{
    /// <summary>
    /// The 'IButton' interface
    /// </summary>
    interface IButton
    {
        void Paint();
    }

    /// <summary>
    /// The 'IGuiFactory' interface
    /// </summary>
    interface IGuiFactory
    {
        IButton CreateButton();
    }

    /// <summary>
    /// The 'IGuiFactory' implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.Gui.IGuiFactory" />    
    class WinFactory : IGuiFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }
    }

    /// <summary>
    /// The 'IGuiFactory' implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.Gui.IGuiFactory" />    
    class OsxFactory : IGuiFactory
    {

        public IButton CreateButton()
        {
            return new OsxButton();
        }
    }

    /// <summary>
    /// The 'Concrete' Class
    /// </summary>
    /// <seealso cref="AbstractFactory.Gui.IButton" />    
    class WinButton : IButton
    {
        public void Paint()
        {
            // Render a button in windows style
        }
    }

    /// <summary>
    /// The 'Concrete' Class
    /// </summary>
    /// <seealso cref="AbstractFactory.Gui.IButton" />    
    class OsxButton : IButton
    {
        public void Paint()
        {
            // Render a button in MacOs style
        }
    }

    /// <summary>
    /// The 'Settings' Class
    /// </summary>
    static class Settings
    {
        public static Appear Appearance { get; set; }

        public enum Appear
        {
            Win,
            Osx
        }
    }
}
