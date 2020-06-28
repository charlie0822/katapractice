using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kata4
{
    class Kata4
    {
        public static int DuplicateCount(string str)
        {
            if(str.Equals(null)|| str.Equals(" "))
            {
                return -1;
            }
            str = str.ToLower();
            IEnumerable<char> noduplicateword = str.Distinct();
            int[] wordcount;
            int count = 0;
            string duplicateword = "";
            foreach(var word in str)
            {
                if(noduplicateword.Contains(word))
                {
                    if(duplicateword.Contains(word))
                    {
                        count++;
                    }
                    else
                    {
                        duplicateword = duplicateword+word;
                    }
                }
            }

            return count;
        }
    }
}
