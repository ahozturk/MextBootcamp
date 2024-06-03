namespace Custify.Console;

public class Person
{
    // public int Budget { get; private set; }
    private int Budget { get; set; }

    public Person(int startAmount)
    {
        Budget = startAmount;
    }

    public void RequestMoney(int amount)
    {
        System.Console.WriteLine("I have no money!");
    }
}
