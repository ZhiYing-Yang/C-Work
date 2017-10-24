using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            //(3)
            Class1 c1 = new Class1();

            //(4)
            Class1 c2 = new Class1("This is a string");

            //(5)
            Class1 []c3 = new Class1[5];
            Console.ReadKey();
        }
    }
}
