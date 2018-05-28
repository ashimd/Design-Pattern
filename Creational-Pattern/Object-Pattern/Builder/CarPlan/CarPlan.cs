namespace Builder.CarPlan
{
    /// <summary>
    /// The Builder 'CarPlan'
    /// </summary>
    public interface CarPlan
    {
        void SetBase(string basement);
        void SetWheels(string structure);
        void SetEngine(string structure);
        void SetRoof(string structure);
        void SetMirrors(string roof);
        void SetLights(string roof);
        void SetInterior(string interior);
    }

    /// <summary>
    /// Additional interface to store Attributes
    /// </summary>
    public interface CarAttribs
    {
        string Properties { get; set; }
    }

    /// <summary>
    /// The 'Product' class
    /// </summary>
    /// <seealso cref="Builder.CarPlan" />
    /// <seealso cref="Builder.CarAttribs" />
    public class Car : CarPlan, CarAttribs
    {
        private string _base { get; set; }
        private string _wheels { get; set; }
        private string _engine { get; set; }
        private string _roof { get; set; }
        private string _mirrors { get; set; }
        private string _lights { get; set; }
        private string _interior { get; set; }

        public void SetBase(string basement)
        {
            _base = basement;
            Properties += _base + "\n";
        }

        public void SetWheels(string wheels)
        {
            _wheels = wheels;
            Properties += _wheels + "\n";
        }

        public void SetEngine(string engine)
        {
            _engine = engine;
            Properties += _engine + "\n";
        }

        public void SetRoof(string roof)
        {
            _roof = roof;
            Properties += _roof + "\n";
        }

        public void SetMirrors(string mirrors)
        {
            _mirrors = mirrors;
            Properties += _mirrors + "\n";
        }

        public void SetLights(string lights)
        {
            _lights = lights;
            Properties += _lights + "\n";
        }

        public void SetInterior(string interior)
        {
            _interior = interior;
            Properties += _interior + "\n";
        }

        public string Properties { get; set; }
    }

    /// <summary>
    /// The 'Builder' interface
    /// </summary>
    public interface CarBuilder
    {
        void BuildBase();
        void BuildWheels();
        void BuildEngine();
        void BuildRoof();
        void BuildMirrors();
        void BuildLights();
        void BuildInterior();
        Car GetCar();
    }

    /// <summary>
    /// The 'ConcreteBuilder' class
    /// </summary>
    /// <seealso cref="Builder.CarBuilder" />
    public class LowPriceCarBuilder : CarBuilder
    {
        private Car car;

        public LowPriceCarBuilder()
        {
            car = new Car();
        }

        public void BuildBase()
        {
            car.SetBase("Low Priced Base");
        }

        public void BuildWheels()
        {
            car.SetWheels("Cheap Tyres");
        }

        public void BuildEngine()
        {
            car.SetEngine("Low Quality Engine");
        }

        public void BuildRoof()
        {
            car.SetRoof("No flexible roof");
        }

        public void BuildMirrors()
        {
            car.SetMirrors("Cheap Mirrors");
        }

        public void BuildLights()
        {
            car.SetLights("Cheap Lights");
        }

        public void BuildInterior()
        {
            car.SetInterior("Cheap Interior");
        }

        public Car GetCar()
        {
            return car;
        }
    }

    /// <summary>
    /// The 'ConcreteBuilder' class
    /// </summary>
    /// <seealso cref="Builder.CarBuilder" />
    public class HighEndCarBuilder : CarBuilder
    {
        private Car car;

        public HighEndCarBuilder()
        {
            car = new Car();
        }

        public void BuildBase()
        {
            car.SetBase("Quality Base");
        }

        public void BuildWheels()
        {
            car.SetWheels("Quality Tyres");
        }

        public void BuildEngine()
        {
            car.SetEngine("High-end Engine");
        }

        public void BuildRoof()
        {
            car.SetRoof("Flexible roof");
        }

        public void BuildMirrors()
        {
            car.SetMirrors("Quaity Mirrors");
        }

        public void BuildLights()
        {
            car.SetLights("Quality Lights");
        }

        public void BuildInterior()
        {
            car.SetInterior("High-end Interior");
        }

        public Car GetCar()
        {
            return car;
        }
    }

    /// <summary>
    /// The 'Director' class
    /// </summary>
    public class MechanicalEngineer
    {
        private CarBuilder carBuilder;

        public MechanicalEngineer(CarBuilder builder)
        {
            carBuilder = builder;
        }

        public Car GetCar()
        {
            return carBuilder.GetCar();
        }

        public void BuildCar()
        {
            carBuilder.BuildBase();
            carBuilder.BuildWheels();
            carBuilder.BuildEngine();
            carBuilder.BuildRoof();
            carBuilder.BuildMirrors();
            carBuilder.BuildLights();
            carBuilder.BuildInterior();
        }
    }
}
