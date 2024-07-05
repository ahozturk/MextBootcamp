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
    public static void bonAppetit(List<int> bill, int k, int b)
    {
        //3 10 2 9
        //k -> 1
        
        int annaShare = 0; //14
    
        for (int i = 0; i < bill.Count; i++) //3
        {
            if (i != k)
                annaShare += bill[i];
        }
        
        int annaNeedToPay = annaShare / 2;
        
        int difference = b - annaNeedToPay;
        
        if (difference > 0)
            Console.WriteLine(difference);
        else
            Console.WriteLine("Bon Appetit");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        Result.bonAppetit(bill, k, b);
    }
}
