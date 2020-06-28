using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kata3
{
    class Kata3
    {
        public static string BandNameGenerator(string str)
        {
            var bandname = "";
            if(str==null||str.Length==0)
            {
                return bandname;
            }
            int strnumber = str.Length;
            var firstchar = str.Substring(0, 1);
            var endchar = str.Substring(strnumber - 1, 1);
            var middlechar = str.Substring(1, strnumber - 1);
            if (firstchar == endchar)
            {

                bandname = firstchar.ToUpper() + middlechar + middlechar;
            }
            else
            {

                bandname = "The " + firstchar.ToUpper() + middlechar;
            }
            return bandname;
        }
    }
}

