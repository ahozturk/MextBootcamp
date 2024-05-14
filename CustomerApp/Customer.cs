namespace CustomerApp;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string PhoneNumber { get; set; }
    public string Mail { get; set; }
    public string Address { get; set; } //ToDo: Make it in a Model
    public Gender Gender { get; set; }

    //8

    public Customer(string name, string surname)
    {
        //""
        if (name.Replace(" ", "").Length == 0)
            Name = "Unknown";
        else
            Name = name;

        if (surname.Length == 0)
            Surname = "Unknown";
        else
            Surname = surname;
    }

}
