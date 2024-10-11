using ShapeCalculator;

namespace ShapeCalculator_Tests;

public class ShapeTests
{
    [Fact]
    public void Circle_CalculateArea_ReturnsCorrectResult()
    {
        var circle = new Circle(5);
        double expectedArea = Math.PI * 25;
        Assert.Equal(expectedArea, circle.CalculateArea(), 5);
    }

    [Fact]
    public void Triangle_CalculateArea_ReturnsCorrectResult()
    {
        var triangle = new Triangle(3, 4, 5);
        double expectedArea = 6;
        Assert.Equal(expectedArea, triangle.CalculateArea(), 5);
    }

    [Fact]
    public void Triangle_IsRightTriangle_ReturnsTrueForRightTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void Triangle_IsRightTriangle_ReturnsFalseForNonRightTriangle()
    {
        var triangle = new Triangle(5, 5, 5);
        Assert.False(triangle.IsRightTriangle());
    }
}
