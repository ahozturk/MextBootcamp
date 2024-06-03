namespace APIRecap;

public class PersonService
{
    static List<string> people = new();
    public void SavePerson(string name)
    {
        people.Add(name);
        Console.WriteLine($"Added {name}");
    }

    public void UpdatePerson(string oldName, string newName)
        {
            foreach (var person in people)
            {
                if (person == oldName)
                {
                    people.Remove(person);
                    people.Add(newName);
                    Console.WriteLine($"Updated {oldName} to {newName}");
                    break;
                }
            }
        }

        public List<string> GetPeople()
        {
            return people;
        }
}
