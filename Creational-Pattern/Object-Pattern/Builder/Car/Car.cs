namespace Builder.Car
{
    /// <summary>
    /// Represents a product created by the builder
    /// </summary>
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int NumDoors { get; set; }
        public string Color { get; set; }

        public Car(string make, string model, string color, int numDoors)
        {
            Make = make;
            Model = model;
            Color = color;
            NumDoors = numDoors;
        }
    }

    /// <summary>
    /// The builder abstraction
    /// </summary>
    public interface ICarBuilder
    {
        string Color { get; set; }
        int NumDoors { get; set; }

        Car GetResult();
    }

    /// <summary>
    /// Concrete builder implementation
    /// </summary>
    /// <seealso cref="AbstractFactory.ICarBuilder" />
    public class FerrariBuilder : ICarBuilder
    {
        public string Color { get; set; }

        public int NumDoors { get; set; }

        public Car GetResult()
        {
            return NumDoors == 2 ? new Car("Ferrari", "488 Spider", Color, NumDoors) : null;
        }
    }

    /// <summary>
    /// The director
    /// </summary>
    public class SportsCarBuildDirector
    {
        private ICarBuilder _builder;
        public SportsCarBuildDirector(ICarBuilder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.Color = "Red";
            _builder.NumDoors = 2;
        }
    }
}
