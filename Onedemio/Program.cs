
#region Question
//1) Merdivenden inerken korkuluğa tutunma
//Evet (Kış) - 1
//Hayır (Yaz) - 0

//2) Yükseklik korkusu
//Evet (Kış) - 1
//Hayır (Yaz) - 0

//3) Sporu sevmek
//Evet (Yaz) - 0
//Hayır (Kış) - 1

//Değerlendirme:
//Puan 1<: Kış
//Puan 0: Yaz
#endregion

using Onedemio;

int totalPoint = 0;

// Console.WriteLine("Merdivenden inerken korkuluğa tutunur musun? (Evet/Hayır)");

// string answer1 = Console.ReadLine();

// if (answer1 == "Evet")
//     totalPoint += 1;


// Console.WriteLine("Yükseklik korkun var mı? (Var/Yok)");

// string answer2 = Console.ReadLine();

// if (answer2 == "Var")
//     totalPoint += 1;


// Console.WriteLine("Spor yapmayı sever misin? (Evet/Hayır)");

// string answer3 = Console.ReadLine();

// if (answer3 == "Hayır")
//     totalPoint += 1;

SurveyQuestion surveyQuestion = new()
{
    Question = "Spor yapmayı sever misin?",
    CorrectAnswer = "Hayır",
    WrongAnswer = "Evet"
};

totalPoint += WriteQuestionAndGetAnswer(surveyQuestion);

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
