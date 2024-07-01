class Result
{
    public static int simpleArraySum(List<int> ar)
    {
        int sumOfList = 0;
        
        foreach (int element in ar)
        {
            sumOfList += element;
        }
        
        return sumOfList;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int arCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.simpleArraySum(ar);

        Console.WriteLine(result);
    }
}
