using System;

public class Point
{
    private int x;
    private int y;
    private string name;
    public int X { get { return x; } }
    public int Y { get { return y; } }
    public string Name { get { return name; } }

    public Point(int x, int y, string name)
    {
        this.x = x;
        this.y = y;
        this.name = name;
    }
}
public class Figure
{
    private Point[] points;
    public Figure(Point p1, Point p2, Point p3)
    {
        points = new Point[] { p1, p2, p3 };
    }
    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points = new Point[] { p1, p2, p3, p4 };
    }
    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points = new Point[] { p1, p2, p3, p4, p5 };
    }
    public double GetSideLength(Point A, Point B)
    {
        int dx = B.X - A.X;
        int dy = B.Y - A.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }
    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length - 1; i++)
        {
            perimeter += GetSideLength(points[i], points[i + 1]);
        }
        perimeter += GetSideLength(points[points.Length - 1], points[0]);

        Console.WriteLine("Назва багатокутника: " + points[0].Name);
        Console.WriteLine("Периметр багатокутника: " + perimeter);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(2, 5, "A");
        Point p2 = new Point(1, 5, "B");
        Point p3 = new Point(5, 3, "C");

        Figure triangle = new Figure(p1, p2, p3);
        triangle.CalculatePerimeter();
    }
}
