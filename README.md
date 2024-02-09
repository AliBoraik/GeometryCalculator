# Shape Calculator Library

This C# library provides functionality for calculating the area of different shapes such as circles and triangles. It includes features like unit tests, extensibility for adding other shapes, dynamic computation of shape areas without knowing the shape type at compile-time, and validation for determining if a triangle is right-angled.

## Features

- **Circle Area Calculation**: Calculate the area of a circle given its radius.
- **Triangle Area Calculation**: Calculate the area of a triangle given its three sides.
- **Unit Tests**: Comprehensive unit tests ensure the correctness of calculations.
- **Extensibility**: Easily add support for additional shapes without modifying existing code.
- **Dynamic Computation**: Calculate the area of a shape without prior knowledge of its type at compile-time.
- **Right-Angled Triangle Detection**: Determine whether a triangle is right-angled.

- ## Usage

### Circle Area Calculation

```csharp
double radius = 5.0;
var circle = new Circle(radius);
double circleArea = FigureCalculator.CalculateArea(circle);
Console.WriteLine($"Area of the circle with radius {radius} is {circleArea}");
