using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class MyMain:MyClass
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();
            c.apublic = "访问public成员";
            //c.aprivate = "访问private成员";
            //c.aprotected = "访问protected成员";

            c.bpublic();
            //c.bprivate();
            //c.bprotected();

            /*
             注：
                访问MyClass里的private和protected这两个修饰符修饰的成员和方法会产生编译错误
             */
        }
    }
}
