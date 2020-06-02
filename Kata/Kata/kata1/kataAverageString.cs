using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kata1
{
    class kataAverageString
    {
        public static string AverageString(string str)
        {
            int totalnumber = 0, count = 0;
            Dictionary<string, int> stringtonumber = new Dictionary<string, int>()
            {
                {"zero", 0},
                {"one", 1},
                {"two", 2},
                {"three", 3},
                {"four", 4},
                {"five", 5},
                {"six", 6},
                {"seven", 7},
                {"eight", 8},
                {"nine", 9}
            };
            if (str == null)
            {
                return "n/a";
            }

            string[] splitstring = str.Split(' ');

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
                foreach (var returnnumber in stringtonumber)
                {
                    if (returnnumber.Value == totalnumber)
                    {
                        return returnnumber.Key;
                    }
                }
                return "n/a";
            }
        }
    }
}
