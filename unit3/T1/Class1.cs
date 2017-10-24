using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Class1
    {
        //(1)
        public Class1() {
            Console.WriteLine("该类的类名为："+this.GetType().Name);
        }

        //(2)
        public Class1(string str) {
            Console.WriteLine(str);
        }
    }
}
