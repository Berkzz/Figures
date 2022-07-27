using Figures.Figures;
using System;
using Xunit;

namespace Figures.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(2, Math.PI * 4)]
    [InlineData(3, Math.PI * 9)]
    public void CicleArea_Should_Be_Right(double radius, double area)
    {
        var circle = new Circle(radius);

        Assert.Equal(circle.Area, area);
    }
}