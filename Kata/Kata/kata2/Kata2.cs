using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.kata2
{
    class Kata2
    {
        public static int DeadAntCount(string ants)
        {
            int countnumber = 0;
            if (ants == null)
            {
                return 0;
            }
            string[] stringsplit = ants.Split(' ');

            foreach (var ant in stringsplit)
            {
                for (int i = 0; i < stringsplit.Length; i++)
                {
                    if (ant[i].Equals("a"))
                    {
                        countnumber++;
                    }


                }

            }

            return countnumber;
        }
    }
}