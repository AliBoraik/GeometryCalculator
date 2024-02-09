using GeometryLibrary.Exceptions;
using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Figures;

public class Triangle : IFigure
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsValidTriangle(sideA, sideB, sideC))
            throw new FigureArgumentException("Invalid side lengths for a triangle.");
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double GetArea()
    {
        var s = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
    }

    public bool IsRightAngled()
    {
        var sortedSides = new[] { SideA, SideB, SideC }.OrderByDescending(side => side).ToArray();

        var a = sortedSides[1];
        var b = sortedSides[2];
        var c = sortedSides[0];

        // небольшой допуск для учета проблем с точностью с плавающей запятой
        double tolerance = 1e-9;

        // близок ли квадрат c к сумме квадратов a и b
        return Math.Abs(c * c - (a * a + b * b)) < tolerance;
    }

    private bool IsValidTriangle(double a, double b, double c)
    {
        return a + b > c && a + c > b && b + c > a;
    }
}