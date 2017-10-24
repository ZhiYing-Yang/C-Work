using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class MyClass
    {
        public string apublic = "public成员";
        private string aprivate = "private成员";
        protected string aprotected = "protected成员";

        public void bpublic() {
            Console.WriteLine("public方法");
        }

        private void bprivate() {
            Console.WriteLine("private方法");
        }

        protected void bprotected() {
            Console.WriteLine("protected方法");
        }
    }
}
