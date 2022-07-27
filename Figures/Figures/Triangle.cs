namespace Figures.Figures;

public class Triangle : Figure
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    private double GetArea()
    {
        // полупериметр
        var p = (SideA + SideB + SideC) / 2;

        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    private bool IsRightAngled()
    {
        // квадраты сторон
        var sA = SideA * SideA;
        var sB = SideB * SideB;
        var sC = SideC * SideC;

        return
            (sA + sB == sC) ||
            (sA + sC == sB) ||
            (sC + sB == sA);

    }

    public override double Area => GetArea();

    public bool IsRight => IsRightAngled();
}