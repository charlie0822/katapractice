using System;
using System.Collections.Generic;
public class Kata
{
    public static string AverageString(string str)
    {
        int totalnumber = 0, count = 0;
        Dictionary<int, string> numbertostring = new Dictionary<int, string>();
        Dictionary<string, int> stringtonumber = new Dictionary<string, int>();
        stringtonumber.Add("zero", 0);
        stringtonumber.Add("one", 1);
        stringtonumber.Add("two", 2);
        stringtonumber.Add("three", 3);
        stringtonumber.Add("four", 4);
        stringtonumber.Add("five", 5);
        stringtonumber.Add("six", 6);
        stringtonumber.Add("seven", 7);
        stringtonumber.Add("eight", 8);
        stringtonumber.Add("nine", 9);
        numbertostring.Add(0, "zero");
        numbertostring.Add(1, "one");
        numbertostring.Add(2, "two");
        numbertostring.Add(3, "three");
        numbertostring.Add(4, "four");
        numbertostring.Add(5, "five");
        numbertostring.Add(6, "six");
        numbertostring.Add(7, "seven");
        numbertostring.Add(8, "eight");
        numbertostring.Add(9, "nine");

        string[] splitstring = str.Split(" ");
        foreach (var stringnumber in splitstring)
        {
            if (stringtonumber.ContainsKey(stringnumber))
            {
                totalnumber += stringtonumber[stringnumber];
                count++;
            }
            else
            {
                return "n/a";
            }
        }

        totalnumber = totalnumber / count;
        if (totalnumber > 9)
        {
            return "n/a";
        }
        else
        {
            return numbertostring[totalnumber];
        }
    }
}
