using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_3_2
{
    class RandomHelp
    {
        public static Random rand = new Random();
        public static int getIntRandomNumber(int min, int max) {         
            return rand.Next(min, max);
        }

        public static double doubleRandomNumber() {
            rand.Next();
            return 0;
        }
    }
}
