namespace StudentsApp.Domain;

public class Lecture : EntityBase
{
    public string Title { get; set; }
    public LectureType Type { get; set; }
}
