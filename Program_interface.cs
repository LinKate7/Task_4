interface IGeographicalObject
{
    int CoordinateX { get; set; }
    int CoordinateY { get; set; }
    string Name { get; set; }
    string Description { get; set; }

    public void GetInfo();

}

public class River : IGeographicalObject
{

    private double FlowSpeed;
    private double RiverLength;
    private int coordinateX;
    private int coordinateY;
    private string name;
    private string description;


    public int CoordinateX { get => coordinateX; set { coordinateX = value; } }
    public int CoordinateY { get => coordinateY; set { coordinateY = value; } }
    public string Name { get => name; set { name = value; } }
    public string Description { get => description; set { description = value; } }

    public River(double flowSpeed, double riverLength)
    {
        FlowSpeed = flowSpeed;
        RiverLength = riverLength;
    }

    public void GetInfo()
    {
        Console.WriteLine("X: " + CoordinateX + " Y: " + CoordinateY + " Name: " + Name + " Description: " + Description);
        Console.WriteLine("Flow speed: " + FlowSpeed + " River Length: " + RiverLength);
    }


}
public class Mountain : IGeographicalObject
{

    private double HighestPoint;
    private int coordinateX;
    private int coordinateY;
    private string name;
    private string description;

    public int CoordinateX { get => coordinateX; set { coordinateX = value; } }
    public int CoordinateY { get => coordinateY; set { coordinateY = value; } }
    public string Name { get => name; set { name = value; } }
    public string Description { get => description; set { description = value; } }

    public Mountain(double highestPoint)
    {
        HighestPoint = highestPoint;
    }

    public void GetInfo()
    {
        Console.WriteLine("X: " + coordinateX + " Y: " + coordinateY + " Name: " + name + " Description: " + Description);
        Console.WriteLine("The highest point: " + HighestPoint);
    }
}


class Program
{
    public static void Main(string[] args)
    {
        var mountain = new Mountain(65)
        {
            Name = "Homyak",
            CoordinateX = 6,
            CoordinateY = 7,
            Description = "blabla1"
        };
        Console.WriteLine();
        var river = new River(2, 45)
        {
            Name = "Rostavytsya",
            CoordinateX = 8,
            CoordinateY = 6,
            Description = "blabla2"
        };

        mountain.GetInfo();
        Console.WriteLine();
        river.GetInfo();

    }
}
