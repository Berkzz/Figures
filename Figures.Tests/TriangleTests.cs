using Figures.Figures;
using Xunit;

namespace Figures.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(5, 12, 13)]
    [InlineData(15, 8, 17)]
    [InlineData(25, 24, 7)]
    public void Triangle_Should_Be_Right(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        Assert.True(triangle.IsRight);
    }

    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 12, 13, 30)]
    [InlineData(8, 15, 17, 60)]
    [InlineData(7, 24, 25, 84)]
    public void TriangleArea_Should_Be_Right(double sideA, double sideB, double sideC, double area)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        Assert.Equal(triangle.Area, area, 5);
    }
}