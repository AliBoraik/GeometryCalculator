using GeometryLibrary.Interfaces;

namespace GeometryLibrary.Utility;

public abstract class FigureCalculator
{
    public static double CalculateArea(IFigure figure)
    {
        return figure.GetArea();
    }
}