using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
    {
        int appleCounter = 0;
        int orangeCounter = 0;
        
        foreach (var appleDistance in apples)
        {
            int appleLocation = a + appleDistance;
            
            if (appleLocation >= s && appleLocation <= t)
                appleCounter++;
        }
        
        foreach (var orangeDistance in oranges)
        {
            int orangeLocation = b + orangeDistance;
            
            if (orangeLocation >= s && orangeLocation <= t)
                orangeCounter++;
        }
        
        Console.WriteLine(appleCounter);
        Console.WriteLine(orangeCounter);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int s = Convert.ToInt32(firstMultipleInput[0]);

        int t = Convert.ToInt32(firstMultipleInput[1]);

        string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int a = Convert.ToInt32(secondMultipleInput[0]);

        int b = Convert.ToInt32(secondMultipleInput[1]);

        string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int m = Convert.ToInt32(thirdMultipleInput[0]);

        int n = Convert.ToInt32(thirdMultipleInput[1]);

        List<int> apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();

        List<int> oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

        Result.countApplesAndOranges(s, t, a, b, apples, oranges);
    }
}
