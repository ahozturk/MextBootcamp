namespace Onedemio;

public class SurveyQuestion
{
    public string Question { get; set; }
    public string CorrectAnswer { get; set; } //"Evet", "Var"
    public string WrongAnswer { get; set; } //"Hayır", "Yok"

    public SurveyQuestion(string question, string correctAnswer = "Evet", string wrongAnswer = "Hayır")
    {
        Question = question;
        CorrectAnswer = correctAnswer;
        WrongAnswer = wrongAnswer;
    }
}
