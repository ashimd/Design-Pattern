using System;

namespace Prototype.Vehicle
{
    /// <summary>
    /// 'IEngine' Interface
    /// </summary>
    public interface IEngine
    {
        int Size { get; }
        bool Turbo { get; }
    }

    /// <summary>
    /// 'VehicleColor' enum
    /// </summary>
    public enum VehicleColor
    {
        Unpainted, Blue, Black, Green,
        Red, Silver, White, Yellow
    }

    /// <summary>
    /// 'IVehicle' interface of IClonable type
    /// </summary>
    /// <seealso cref="System.ICloneable" />
    public interface IVehicle : ICloneable
    {
        IEngine Engine { get; }
        VehicleColor Color { get; }
        void Paint(VehicleColor color);
    }

    /// <summary>
    /// Abstact implementation 'AbstractEngine' of 'IEngine'
    /// </summary>
    /// <seealso cref="Prototype.IEngine" />
    public abstract class AbstractEngine : IEngine
    {
        private int size;
        private bool turbo;

        public AbstractEngine(int size, bool turbo)
        {
            this.size = size;
            this.turbo = turbo;
        }

        public virtual int Size
        {
            get
            {
                return size;
            }
        }

        public virtual bool Turbo
        {
            get
            {
                return turbo;
            }
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + size + ")";
        }
    }

    /// <summary>
    /// Concrete 'AbstractEngine' Implementation
    /// </summary>
    /// <seealso cref="Prototype.AbstractEngine" />
    public class StandardEngine : AbstractEngine
    {
        public StandardEngine(int size)
            : base(size, false)
        {
            // not turbocharged
        }
    }

    /// <summary>
    /// Concrete 'AbstractEngine' Implementation
    /// </summary>
    /// <seealso cref="Prototype.AbstractEngine" />
    public class TurboEngine : AbstractEngine
    {
        public TurboEngine(int size)
            : base(size, true)
        {
            // turbocharged
        }
    }

    /// <summary>
    /// Abstact implementation 'AbstractVehicle' of 'IVehicle'
    /// </summary>
    /// <seealso cref="Prototype.IVehicle" />
    public abstract class AbstractVehicle : IVehicle
    {
        private IEngine engine;
        private VehicleColor color;

        public AbstractVehicle(IEngine engine) :
            this(engine, VehicleColor.Unpainted) { }

        public AbstractVehicle(IEngine engine, VehicleColor color)
        {
            this.engine = engine;
            this.color = color;
        }

        public virtual IEngine Engine
        {
            get
            {
                return engine;
            }
        }

        public virtual VehicleColor Color
        {
            get
            {
                return color;
            }
        }

        public virtual void Paint(VehicleColor color)
        {
            this.color = color;
        }

        public virtual object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return this.GetType().Name + " (" + engine + ", " + color + ")";
        }
    }

    /// <summary>
    /// Abstact implementation 'AbstractCar' of 'AbstractVehicle'
    /// </summary>
    /// <seealso cref="Prototype.AbstractVehicle" />
    public abstract class AbstractCar : AbstractVehicle
    {
        public AbstractCar(IEngine engine)
            : this(engine, VehicleColor.Unpainted) { }

        public AbstractCar(IEngine engine, VehicleColor color)
            : base(engine, color) { }
    }

    /// <summary>
    /// Abstact implementation 'AbstractVan' of 'AbstractVehicle'
    /// </summary>
    /// <seealso cref="Prototype.AbstractVehicle" />
    public abstract class AbstractVan : AbstractVehicle
    {
        public AbstractVan(IEngine engine)
            : this(engine, VehicleColor.Unpainted) { }

        public AbstractVan(IEngine engine, VehicleColor color)
            : base(engine, color) { }
    }

    /// <summary>
    /// 'AbstractCar' concrete implementation
    /// </summary>
    /// <seealso cref="Prototype.AbstractCar" />
    public class Saloon : AbstractCar
    {
        public Saloon(IEngine engine)
            : this(engine, VehicleColor.Unpainted) { }

        public Saloon(IEngine engine, VehicleColor color)
            : base(engine, color) { }
    }

    /// <summary>
    /// 'AbstractCar' concrete implementation
    /// </summary>
    /// <seealso cref="Prototype.AbstractCar" />
    public class Coupe : AbstractCar
    {
        public Coupe(IEngine engine)
            : this(engine, VehicleColor.Unpainted) { }

        public Coupe(IEngine engine, VehicleColor color)
            : base(engine, color) { }
    }

    /// <summary>
    /// 'AbstractCar' concrete implementation
    /// </summary>
    /// <seealso cref="Prototype.AbstractCar" />
    public class Sport : AbstractCar
    {
        public Sport(IEngine engine)
            : this(engine, VehicleColor.Unpainted) { }

        public Sport(IEngine engine, VehicleColor color)
            : base(engine, color) { }
    }

    /// <summary>
    /// 'AbstractVan' concrete implementation
    /// </summary>
    /// <seealso cref="Prototype.AbstractVan" />
    public class BoxVan : AbstractVan
    {
        public BoxVan(IEngine engine)
            : this(engine, VehicleColor.Unpainted) { }

        public BoxVan(IEngine engine, VehicleColor color)
            : base(engine, color) { }
    }

    /// <summary>
    /// 'AbstractVan' concrete implementation
    /// </summary>
    /// <seealso cref="Prototype.AbstractVan" />
    public class Pickup : AbstractVan
    {
        public Pickup(IEngine engine)
            : this(engine, VehicleColor.Unpainted) { }

        public Pickup(IEngine engine, VehicleColor color)
            : base(engine, color) { }
    }

    /// <summary>
    /// The 'VehicleManager' to construct concrete implementation
    /// </summary>
    public class VehicleManager
    {
        private IVehicle saloon, coupe, sport, boxVan, pickup;

        public VehicleManager()
        {
            // For simplicity all vehicles use same engine type...
            saloon = new Saloon(new StandardEngine(1300));
            coupe = new Coupe(new StandardEngine(1300));
            sport = new Sport(new StandardEngine(1300));
            boxVan = new BoxVan(new StandardEngine(1300));
            pickup = new Pickup(new StandardEngine(1300));
        }

        public virtual IVehicle CreateSaloon()
        {
            return (IVehicle)saloon.Clone();
        }

        public virtual IVehicle CreateCoupe()
        {
            return (IVehicle)coupe.Clone();
        }

        public virtual IVehicle CreateSport()
        {
            return (IVehicle)sport.Clone();
        }

        public virtual IVehicle CreateBoxVan()
        {
            return (IVehicle)boxVan.Clone();
        }

        public virtual IVehicle CreatePickup()
        {
            return (IVehicle)pickup.Clone();
        }
    }

    /// <summary>
    /// The 'VehicleManagerLazy' to lazy initialize concrete implementation
    /// </summary>
    public class VehicleManagerLazy {
        private IVehicle saloon, coupe, sport, boxVan, pickup;

        public VehicleManagerLazy() { }

        public virtual IVehicle CreateSaloon() {
            if (saloon == null)
                saloon = new Saloon(new StandardEngine(1300));
            return (IVehicle)saloon.Clone();
        }

        public virtual IVehicle CreateCoupe()
        {
            if (coupe == null)
                coupe = new Saloon(new StandardEngine(1300));
            return (IVehicle)coupe.Clone();
        }

        public virtual IVehicle CreateSport()
        {
            if (sport == null)
                sport = new Saloon(new StandardEngine(1300));
            return (IVehicle)sport.Clone();
        }

        public virtual IVehicle CreateBoxVan()
        {
            if (boxVan == null)
                boxVan = new Saloon(new StandardEngine(1300));
            return (IVehicle)boxVan.Clone();
        }

        public virtual IVehicle CreatePickup()
        {
            if (pickup == null)
                pickup = new Saloon(new StandardEngine(1300));
            return (IVehicle)pickup.Clone();
        }
    }
}
