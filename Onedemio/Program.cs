using Onedemio;

int totalPoint = 0;

List<SurveyQuestion> surveyQuestions = new()
{
    new()
    {
        Question = "Merdivenden inerken korkuluğa tutunur musun?",
        CorrectAnswer = "Evet",
        WrongAnswer = "Hayır"
    },
    new()
    {
        Question = "Spor yapmayı sever misin?",
        CorrectAnswer = "Hayır",
        WrongAnswer = "Evet"
    },
    new()
    {
        Question = "Yükseklikten korkar mısın?",
        CorrectAnswer = "Evet",
        WrongAnswer = "Hayır"
    }
};


foreach (var surveyQuestion in surveyQuestions)
{
    totalPoint += WriteQuestionAndGetAnswer(surveyQuestion);
}



int WriteQuestionAndGetAnswer(SurveyQuestion surveyQuestion)
{
    Console.WriteLine($"{surveyQuestion.Question} ({surveyQuestion.CorrectAnswer}/{surveyQuestion.WrongAnswer})");

    string answer = Console.ReadLine();

    if (answer == surveyQuestion.CorrectAnswer)
        return 1;
    
    else
        return 0;
}


Console.WriteLine($"Değerlendirme: {totalPoint}");

//totalPoint = 15

if (totalPoint >= 0 && totalPoint <= 3)
{
    if (totalPoint <= 1)
        Console.WriteLine("Yaz");
        
    else if (totalPoint >= 2)
        Console.WriteLine("Kış");
}
else
    Console.WriteLine("Geçersiz değerlendirme");
