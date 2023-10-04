public abstract class GeographicalObject
{
    protected int CoordinateX;
    protected int CoordinateY;
    protected string Name;
    protected string Description;

    public GeographicalObject(int x, int y, string name)
    {
        CoordinateX = x;
        CoordinateY = y;
        Name = name; 
    }

    public virtual void GetInfo()
    {

    }

}

public class River : GeographicalObject
{
    private double FlowSpeed;
    private double RiverLength;
    public River(int x, int y, string name, double flowSpeed, double riverLength) : base(x, y, name)
    {
        FlowSpeed = flowSpeed;
        RiverLength = riverLength;
    }
  
    public override void GetInfo()
    {
        Console.WriteLine("X: " + CoordinateX + " Y: " + CoordinateY + " Name: " + Name);
        Console.WriteLine("Flow speed: " + FlowSpeed + " River Length: " + RiverLength);
    }


}

public class Mountain : GeographicalObject
{
    private double HighestPoint;
    public Mountain(int x, int y, string name, double highestPoint) : base(x, y, name)
    {
        HighestPoint = highestPoint;
    }

    public override void GetInfo()
    {
        Console.WriteLine("X: " + CoordinateX + " Y: " + CoordinateY + " Name: " + Name);
        Console.WriteLine("The highest point: " + HighestPoint);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Mountain mountain = new Mountain(4, 5, "Homyak", 65);
        River river = new River(2, 9, "Rostavytsya", 2, 5);
        mountain.GetInfo();
        Console.WriteLine();
        river.GetInfo();

    }
}
