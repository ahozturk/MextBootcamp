
using Gradify.Concrete;

METUniversity metuuniversity = new();
metuuniversity.Midterm = 50;
metuuniversity.Final = 70;
var metuGrade = metuuniversity.CalculateGrade();
Console.WriteLine($"METU Grade: {metuGrade}");


BogaziciUniversity bogaziciuniversity = new();
bogaziciuniversity.Quiz1 = 50;
bogaziciuniversity.Quiz2 = 60;
bogaziciuniversity.Midterm = 50;
bogaziciuniversity.Final = 70;
var bogaziciGrade = bogaziciuniversity.CalculateGrade();
Console.WriteLine($"Bogazici Grade: {bogaziciGrade}");
