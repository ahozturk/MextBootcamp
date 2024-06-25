using EFCore.Console;
using EFCore.Console.Entities;

AppDbContext dbContext = new();

var student1 = new Student()
{
    Id = Guid.NewGuid(),
    FirstName = "John",
    LastName = "Doe"
};

var student2 = new Student()
{
    Id = Guid.NewGuid(),
    FirstName = "Hakan",
    LastName = "Öztürk"
};

dbContext.Students.Add(student1);
dbContext.Students.Add(student2);

dbContext.SaveChanges();

var students = dbContext.Students.ToList();



var deletedStudent = dbContext.Students.FirstOrDefault(x => x.FirstName == "Hakan");

dbContext.Students.Remove(deletedStudent);
dbContext.SaveChanges();

// foreach (var student in students)
// {
//     if (student.FirstName == "Hakan")
//     {
//         dbContext.Students.Remove(student);
//         dbContext.SaveChanges();
//         Console.WriteLine("Hakan removed from the database");
//     }
// }

students = dbContext.Students.ToList();

foreach (var student in students)
    Console.WriteLine($"Student: {student.FirstName} {student.LastName}");