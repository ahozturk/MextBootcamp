using LearningInterfaces.Abstractions;

namespace LearningInterfaces.Concretes;

public class Rectangle : IShape
{
    public decimal SideA { get; set; }
    public decimal SideB { get; set; }

    public decimal CalculateArea()
    {
        return SideA * SideB;
    }

    public decimal CalculatePerimeter()
    {
        return 2 * (SideA + SideB);
    }
}
