using System;
using GeometryLibrary.Exceptions;
using GeometryLibrary.Figures;
using GeometryLibrary.Utility;
using Xunit;

namespace GeometryTests;

public class CircleTests
{
    [Theory]
    [InlineData(4)]
    [InlineData(5)]
    [InlineData(10)]
    public void CircleAreaCalculation(double radius)
    {
        // Arrange
        var circle = new Circle(radius);

        // Act
        double area = FigureCalculator.CalculateArea(circle);

        // Assert
        Assert.Equal(Math.PI * radius * radius, area);
    }

    [Theory]
    [InlineData(-1)] // с отрицательным радиусом
    [InlineData(-10.5)]
    public void CircleWithNegativeRadius(double radius)
    {
        // Arrange & Act & Assert
        Assert.Throws<FigureArgumentException>(() => new Circle(radius));
    }
}