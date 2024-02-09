using GeometryLibrary.Exceptions;
using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Figures;

public class Circle : IFigure
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius < 0) throw new FigureArgumentException("Radius cannot be negative.");
        Radius = radius;
    }
    public double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}