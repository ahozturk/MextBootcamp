namespace Gradify.Concrete;

public class METUniversity : IGradeCalculation
{
    public int Midterm { get; set; }
    public int Final { get; set; }
    public double CalculateGrade()
    {
        return (Midterm * 0.4) + (Final * 0.6);
    }
}
