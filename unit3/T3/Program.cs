using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             先初始化全局变量 输出B
             再调用构造方法（先调用父类的输出A, 在调用子类的输出C）
             */
            C c = new C();
            Console.ReadKey();
            /*(3)运行结果为：
             B
             A
             */

            /*(4)运行结果为：
             B
             A
             C
             */
        }
    }
}
