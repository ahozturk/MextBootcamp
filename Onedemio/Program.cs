using Onedemio;

int totalPoint = 0;

List<SurveyQuestion> surveyQuestions = new()
{
    // new("Merdivenden inerken korkuluğa tutunur musun?"),
    // new("Spor yapmayı sever misin?", "Hayır", "Evet"),
    // new("Yükseklikten korkar mısın?"),
    new("Evcil hayvanın var mı?", "Yok", "Var"),
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
