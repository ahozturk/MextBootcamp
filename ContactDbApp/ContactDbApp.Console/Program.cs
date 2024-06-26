using ContactDbApp.Domain;

Console.WriteLine("Hello, World!");

ContactDbAppDbContext context = new();

var lecture1 = new Lecture
{
    Id = Guid.NewGuid(),
    Title = "Introduction to EF Core",
    Type = LectureType.Online,
};

var lecture2 = new Lecture
{
    Id = Guid.NewGuid(),
    Title = "Introduction to EF Core",
    Type = LectureType.Online,
};

context.Lectures.Add(lecture1);
context.Lectures.Add(lecture2);

context.SaveChanges();

var findLecture = context.Lectures.FirstOrDefault(x => x.Title == "Introduction to EF Core");

findLecture.Type = LectureType.Hybrid;

context.SaveChanges();

context.Lectures.Remove(findLecture);

context.SaveChanges();
