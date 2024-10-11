namespace ShapeCalculator;
public record Triangle : IShape
{
    public double SideA { get; init; }
    public double SideB { get; init; }
    public double SideC { get; init; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsValidTriangle(sideA, sideB, sideC))
        {
            throw new ArgumentException("Заданные стороны не могут быть треугольником.");
        }

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    public double CalculateArea()
    {
        double semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }

    public bool IsRightTriangle()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs((sides[0] * sides[0]) + (sides[1] * sides[1]) - (sides[2] * sides[2])) < 1e-10;
    }

    private static bool IsValidTriangle(double a, double b, double c) 
        => a + b > c && a + c > b && b + c > a;
}
