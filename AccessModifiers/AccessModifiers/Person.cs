namespace AccessModifiers;

public class Person
{
    private string Name { get; set; }
    private int Balance { get; set; }

    public void SetName(string name)
    {
        if (name.Length > 3)
        {
            Name = name;
            Console.WriteLine($"Name set to {Name}");
        }
        
        else
            Console.WriteLine("Name must be more than 3 characters");
    }

    public void Withdraw(int amount)
    {
        if (amount > 200)
        {
            Console.WriteLine("You can't withdraw more than 200");
        }
        else
        {
            Balance -= amount;
            System.Console.WriteLine($"You have withdrawn {amount}. Your new balance is {Balance}");
        }
    }
}
