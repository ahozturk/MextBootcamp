namespace Gradify.Concrete;

public class BogaziciUniversity : IGradeCalculation
{
    public int Quiz1 { get; set; }
    public int Quiz2 { get; set; }
    public int Midterm { get; set; }
    public int Final { get; set; }

    public double CalculateGrade()
    {
        var quizResult = (Quiz1 + Quiz2) / 2;

        var generalResult = (quizResult * 0.2m) + (Midterm * 0.3m) + (Final * 0.5m);

        return (double)generalResult;
    }
}
