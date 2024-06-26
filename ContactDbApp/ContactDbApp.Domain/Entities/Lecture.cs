namespace ContactDbApp.Domain;

public class Lecture
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public LectureType Type { get; set; }
}
