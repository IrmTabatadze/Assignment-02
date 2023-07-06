using System;

public interface IShapes<T>
{
    int Count { get; }
    void Add(T item);
    T Get(int index);
}

public class GeometricShapes<T> : IShapes<T>
{
    private int size;
    private T[] items;

    public GeometricShapes()
    {
        size = 0;
        items = new T[10];
    }

    public int Count { get { return size; } }

    public void Add(T item)
    {
        this.items[this.size] = item;
        this.size++;
    }

    public T Get(int index) { return this.items[index]; }
}

public interface IRound
{
    string Name { get; }
    double Radius { get; set; }
    double Diameter { get; }
    double Circumference { get; }
    double Area { get; }
}

public class Circle : IRound
{
    protected double rad;
    protected string id;

    public Circle(double radius = 0.00D)
    {
        this.rad = radius;
    }

    public string Name { get { return "Circle"; } }

    public double Radius
    {
        get { return rad; }
        set
        {
            if (rad <= 0) rad = 0;
            else rad = value;
        }
    }

    public double Diameter { get { return rad * 2; } }

    public double Circumference { get { return rad * 2 * 3.14159; } }

    public double Area { get { return rad * rad * 3.14159; } }
}

public class Exercise
{
    public Circle GetShape()
    {
        double rad = 0.00D;

        Console.Write("Enter the radius: ");
        rad = double.Parse(Console.ReadLine());

        return new Circle(rad);
    }

    public void ShowShapes(IShapes<IRound> shps)
    {
        for (int i = 0; i < shps.Count; i++)
        {
            IRound rnd = shps.Get(i);

            Console.WriteLine("================================");
            Console.WriteLine("{0} Characteristics", rnd.Name);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Radius:        {0}", rnd.Radius);
            Console.WriteLine("Diameter:      {0}", rnd.Diameter);
            Console.WriteLine("Circumference: {0}", rnd.Circumference);
            Console.WriteLine("Area:          {0}", rnd.Area);
        }
        Console.WriteLine("===============================");
    }

    public static int Main()
    {
        Exercise exo = new Exercise();
        GeometricShapes<IRound> shapes = new GeometricShapes<IRound>();

        IRound rnd = exo.GetShape();
        shapes.Add(rnd);
        rnd = exo.GetShape();
        shapes.Add(rnd);
        rnd = exo.GetShape();
        shapes.Add(rnd);
        rnd = exo.GetShape();
        shapes.Add(rnd);
        rnd = exo.GetShape();
        shapes.Add(rnd);

        Console.Clear();
        exo.ShowShapes(shapes);

        return 0;
    }
}