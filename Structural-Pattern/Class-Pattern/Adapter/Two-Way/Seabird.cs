using System;

namespace Adapter.TwoWay
{
    // Two-Way Adapter Pattern      Pierre-Henri Kuate and Judith Bishop Aug 2007
    // Embedded system for a Seabird flying plane

    // ITarget interfae
    public interface IAircraft
    {
        bool Airborne { get; }
        int Height { get; }

        void TakeOff();
    }

    // Target
    public sealed class Aircraft : IAircraft
    {
        int height;
        bool airborne;
        public Aircraft()
        {
            height = 0;
            airborne = false;
        }

        public void TakeOff()
        {
            Console.WriteLine("Aircraft engine takeoff");
            airborne = true;
            height = 200; // Meters
        }

        public bool Airborne
        {
            get { return airborne; }
        }

        public int Height
        {
            get { return height; }
        }
    }

    // Adaptee interface
    public interface ISeacraft
    {
        int Speed { get; }

        void IncreaseRevs();
    }

    // Adaptee implementation
    public class Seacraft : ISeacraft
    {
        int speed = 0;

        public virtual void IncreaseRevs()
        {
            speed += 10;
            Console.WriteLine("Seacraft engine increses revs to " + speed + " knots");
        }

        public int Speed
        {
            get { return speed; }
        }
    }

    // Adapter
    public class Seabird : Seacraft, IAircraft
    {
        int height = 0;

        // A two-way adapter hides and routes the Target's methods
        // Use Seacraft instructions to implement this one
        public void TakeOff()
        {
            while (!Airborne)
                IncreaseRevs();
        }

        // Routes this straight back to the Aircraft
        public int Height
        {
            get { return height; }
        }

        // This method is common to both Target and Adaptee
        public override void IncreaseRevs()
        {
            base.IncreaseRevs();
            if (Speed > 40)
                height += 100;
        }

        public bool Airborne
        {
            get { return height > 50; }
        }
    }    
}
