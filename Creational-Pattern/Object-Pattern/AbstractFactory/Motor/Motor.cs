
namespace AbstractFactory.Motor
{
    /// <summary>
    /// Interface 'IBody'
    /// </summary>
    public interface IBody
    {
        string BodyParts { get; }
    }

    /// <summary>
    /// 'IBody' Implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.IBody" />
    public class CarBody : IBody
    {
        public virtual string BodyParts
        {
            get
            {
                return "Body shell parts for a car";
            }
        }
    }

    /// <summary>
    /// 'IBody' Implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.IBody" />
    public class VanBody : IBody
    {
        public virtual string BodyParts
        {
            get
            {
                return "Body shell parts for a van";
            }
        }
    }

    /// <summary>
    /// Interface 'IChassis'
    /// </summary>
    public interface IChassis
    {
        string ChassisParts { get; }
    }

    /// <summary>
    /// 'IChassis' Implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.IChassis" />
    public class CarChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get
            {
                return "Chassis parts for a car";
            }
        }
    }

    /// <summary>
    /// 'IChassis' Implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.IChassis" />
    public class VanChassis : IChassis
    {
        public virtual string ChassisParts
        {
            get
            {
                return "Chassis parts for a van";
            }
        }
    }

    /// <summary>
    /// Interface 'IGlassware'
    /// </summary>
    public interface IGlassware
    {
        string GlasswareParts { get; }
    }

    /// <summary>
    /// 'IGlassware' Implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.IGlassware" />
    public class CarGlassware : IGlassware
    {
        public virtual string GlasswareParts
        {
            get
            {
                return "Window glassware for a car";
            }
        }
    }

    /// <summary>
    /// 'IGlassware' Implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.IGlassware" />
    public class VanGlassware : IGlassware
    {
        public virtual string GlasswareParts
        {
            get
            {
                return "Window glassware for a van";
            }
        }
    }

    /// <summary>
    /// Abstract Factory 'AbstractVehicleFactory'
    /// </summary>
    public abstract class AbstractVehicleFactory
    {
        public abstract IBody CreateBody();
        public abstract IChassis CreateChassis();
        public abstract IGlassware CreateGlassware();
    }

    /// <summary>
    /// 'AbstractVehicleFactory' concrete implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.AbstractVehicleFactory" />
    public class CarFactory : AbstractVehicleFactory
    {

        public override IBody CreateBody()
        {
            return new CarBody();
        }

        public override IChassis CreateChassis()
        {
            return new CarChassis();
        }

        public override IGlassware CreateGlassware()
        {
            return new CarGlassware();
        }
    }

    /// <summary>
    /// 'AbstractVehicleFactory' concrete implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.AbstractVehicleFactory"/>
    public class VanFactory : AbstractVehicleFactory
    {

        public override IBody CreateBody()
        {
            return new VanBody();
        }

        public override IChassis CreateChassis()
        {
            return new VanChassis();
        }

        public override IGlassware CreateGlassware()
        {
            return new VanGlassware();
        }
    }
}
