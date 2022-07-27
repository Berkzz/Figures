namespace Figures.Figures;

public class Circle : Figure
{
    public double Radius { get; }
    public double Diameter { get; }

    public Circle(double radius)
    {
        Radius = radius;
        Diameter = radius * 2;
    }

    private double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public override double Area => GetArea();
}