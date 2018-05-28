namespace Builder.House
{
    /// <summary>
    /// The 'Floor' interface
    /// </summary>
    public interface Floor
    {
        string GetRepresentation();
    }

    /// <summary>
    /// The 'Walls' interface
    /// </summary>
    public interface Walls
    {
        string GetRepresentation();
    }

    /// <summary>
    /// The 'Roof' interface
    /// </summary>
    public interface Roof
    {
        string GetRepresentation();
    }

    /// <summary>
    /// The 'House' class
    /// </summary>
    public abstract class House
    {
        protected Floor floor;
        protected Walls walls;
        protected Roof roof;

        public Floor GetFloor()
        {
            return floor;
        }

        public void SetFloor(Floor _floor)
        {
            this.floor = _floor;
        }

        public Walls GetWalls()
        {
            return walls;
        }

        public void SetWalls(Walls _walls)
        {
            this.walls = _walls;
        }

        public Roof GetRoof()
        {
            return roof;
        }

        public void SetRoof(Roof _roof)
        {
            this.roof = _roof;
        }

        public abstract string GetRepresentation();
    }    
    
    /// <summary>
    /// The 'HouseBuilder' class
    /// </summary>
    public abstract class HouseBuilder
    {
        protected House house;
        protected Floor floor;
        protected Walls walls;
        protected Roof roof;
        public abstract House CreateHouse();
        public abstract Floor CreateFloor();
        public abstract Walls CreateWalls();
        public abstract Roof CreateRoof();
    }

    /// <summary>
    /// The 'WoodHouse' class
    /// </summary>
    /// <seealso cref="Builder.House" />
    public class WoodHouse : House
    {
        public override string GetRepresentation()
        {
            return "Building a wood house";
        }
    }

    /// <summary>
    /// The 'WoodFloor' class
    /// </summary>
    /// <seealso cref="Builder.Floor" />
    public class WoodFloor : Floor
    {
        public string GetRepresentation()
        {
            return "Finished building wood floor";
        }
    }

    /// <summary>
    /// The 'WoodWalls' class
    /// </summary>
    /// <seealso cref="Builder.Walls" />
    public class WoodWalls : Walls
    {
        public string GetRepresentation()
        {
            return "Finished building wood walls";
        }
    }

    /// <summary>
    /// The 'WoodRoof' class
    /// </summary>
    /// <seealso cref="Builder.Roof" />
    public class WoodRoof : Roof
    {
        public string GetRepresentation()
        {
            return "Finished building wood roof";
        }
    }

    /// <summary>
    /// The 'BrickHouse' class
    /// </summary>
    /// <seealso cref="Builder.House" />
    public class BrickHouse : House
    {
        public override string GetRepresentation()
        {
            return "Building a brick house";
        }
    }

    /// <summary>
    /// The 'BrickFloor' class
    /// </summary>
    /// <seealso cref="Builder.Floor" />
    public class BrickFloor : Floor
    {
        public string GetRepresentation()
        {
            return "Finished building brick floor";
        }
    }

    /// <summary>
    /// The 'BrickWalls' class
    /// </summary>
    /// <seealso cref="Builder.Walls" />
    public class BrickWalls : Walls
    {
        public string GetRepresentation()
        {
            return "Finished building brick walls";
        }
    }

    /// <summary>
    /// The 'BrickRoof' class
    /// </summary>
    /// <seealso cref="Builder.Roof" />
    public class BrickRoof : Roof
    {
        public string GetRepresentation()
        {
            return "Finished building brick roof";
        }
    }

    /// <summary>
    /// The 'WoodBuilder' class
    /// </summary>
    /// <seealso cref="Builder.HouseBuilder" />
    public class WoodBuilder : HouseBuilder
    {
        public override House CreateHouse()
        {
            house = new WoodHouse();
            return house;
        }

        public override Floor CreateFloor()
        {
            floor = new WoodFloor();
            return floor;
        }

        public override Walls CreateWalls()
        {
            walls = new WoodWalls();
            return walls;
        }

        public override Roof CreateRoof()
        {
            roof = new WoodRoof();
            return roof;
        }
    }

    /// <summary>
    /// The 'BrickBuilder' class
    /// </summary>
    /// <seealso cref="Builder.HouseBuilder" />
    public class BrickBuilder : HouseBuilder
    {
        public override House CreateHouse()
        {
            house = new BrickHouse();
            return house;
        }

        public override Floor CreateFloor()
        {
            floor = new BrickFloor();
            return floor;
        }

        public override Walls CreateWalls()
        {
            walls = new BrickWalls();
            return walls;
        }

        public override Roof CreateRoof()
        {
            roof = new BrickRoof();
            return roof;
        }
    }

    /// <summary>
    /// The 'HouseDirector' class
    /// </summary>
    public class HouseDirector
    {
        public House ConstructHouse(HouseBuilder builder)
        {
            House house = builder.CreateHouse();
            Console.WriteLine(house.GetRepresentation());

            house.SetFloor(builder.CreateFloor());
            Console.WriteLine(house.GetFloor().GetRepresentation());

            house.SetWalls(builder.CreateWalls());
            Console.WriteLine(house.GetWalls().GetRepresentation());

            house.SetRoof(builder.CreateRoof());
            Console.WriteLine(house.GetRoof().GetRepresentation());

            return house;
        }
    }
}
