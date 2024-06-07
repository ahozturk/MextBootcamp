namespace InterfaceExampleBankApp;

public class VakifbankBank : IBank, ICSVConvertible
{
    public int Months { get; set; }
    public decimal Amount { get; set; }
    public decimal InterestRate { get; set; }

    public string ConvertToCSV()
    {
        var totalAmount = GetCredit();

        return $"{Amount},{InterestRate},{totalAmount}";
    }

    public decimal GetCredit()
    {

        if (Amount < 30_000)
            InterestRate += 2;

        else if (Amount < 50_000)
            InterestRate += 4;

        else if (Amount < 100_000)
            InterestRate += 10;

        else
            InterestRate += 20;

        
        if (Months < 6)
            InterestRate += 2;

        else if (Months < 12)
            InterestRate += 4;

        else if (Months < 24)
            InterestRate += 8;

        else
            InterestRate += 16;

        var totalAmount = Amount + (Amount * InterestRate / 100);

        Console.WriteLine($"Vakifbank Bank: {Amount} amount with {Months} months has {InterestRate}% interest rate. Total amount: {totalAmount}, monthly amount: {totalAmount / Months}");

        return totalAmount;
    }
}
