using EFCore.Console;
using EFCore.Console.Entities;

AppDbContext dbContext = new();

var student1 = new Student()
{
    Id = Guid.NewGuid(),
    FirstName = "John",
    LastName = "Doe"
};

dbContext.Students.Add(student1);

dbContext.SaveChanges();

var students = dbContext.Students.ToList();

foreach (var student in students)
{
    Console.WriteLine($"Student: {student.FirstName} {student.LastName}");
}