using LearningInterfaces.Abstractions;

namespace LearningInterfaces.Concretes;

public class Circle : IShape
{
    public decimal Radius { get; set; }

    public decimal CalculateArea()
    {
        var result = (decimal)Math.PI * (Radius * Radius);
        return Math.Floor(result * 100) / 100;
    }

    public decimal CalculatePerimeter()
    {
        var result = 2 * (decimal)Math.PI * Radius;
        return Math.Floor(result * 100) / 100;
    }
}
