using GeometryLibrary.Exceptions;
using GeometryLibrary.Figures;
using GeometryLibrary.Utility;
using Xunit;

namespace GeometryTests;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 12, 13, 30)]
    [InlineData(5, 5, 5, 10.83)]
    [InlineData(5, 6, 7, 14.70)]
    public void ValidTriangleAreaCalculation(double sideA, double sideB, double sideC, double expectedArea)
    {
        // Arrange
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act
        double actualArea = FigureCalculator.CalculateArea(triangle);

        // Assert
        Assert.Equal(expectedArea, actualArea, 2);
    }

    [Theory]
    [InlineData(1, 2, 10)]
    [InlineData(2, 10, 1)]
    [InlineData(10, 1, 2)]
    public void InvalidTriangleAreaCalculation(double sideA, double sideB, double sideC)
    {
        // Arrange & Act & Assert
        Assert.Throws<FigureArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Theory]
    [InlineData(0, 4, 5)]
    [InlineData(3, 0, 5)]
    [InlineData(3, 4, 0)]
    public void InvalidTriangleWithZeroSides(double sideA, double sideB, double sideC)
    {
        // Arrange Act & Assert
        Assert.Throws<FigureArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Theory]
    [InlineData(3, 4, 5, true)]
    [InlineData(145, 105, 100, true)]
    [InlineData(70, 130, 110, false)]
    [InlineData(1, 1, 1, false)]
    public void IsRightAngledTriangle(double sideA, double sideB, double sideC, bool expectedResult)
    {
        // Arrange
        var triangle = new Triangle(sideA, sideB, sideC);

        // Act
        bool result = triangle.IsRightAngled();

        // Assert
        Assert.Equal(expectedResult, result);
    }
}