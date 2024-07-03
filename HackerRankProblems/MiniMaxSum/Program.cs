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
    public static void miniMaxSum(List<int> arr)
    {
        //1 2 3 4 5
        long maxSum = 0; //14
        long minSum = 0; //10
        
        int minNumberIndex = arr.IndexOf(arr.Min()); //1
        int maxNumberIndex = arr.IndexOf(arr.Max()); //3
        
        for (int i = 0; i < arr.Count; i++) //4
        {
            if (i == maxNumberIndex && i != minNumberIndex)
                maxSum += arr[i];
            else if (i == minNumberIndex && i != maxNumberIndex)
                minSum += arr[i];
            else if(i != minNumberIndex && i != maxNumberIndex)
            {
                minSum += arr[i];
                maxSum += arr[i];
            }
        }
        
        Console.WriteLine($"{minSum} {maxSum}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
