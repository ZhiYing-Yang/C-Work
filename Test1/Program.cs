using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1)
            int.TryParse(Console.ReadLine(), out int n);
            if (n<=0) {
                return;
            }

            //(2)
            string str = Console.ReadLine();

            //(3)
            Console.WriteLine("第一次出现a的位置是:{0}", str.IndexOf("a"));

            //(4)
            string str4 = str.Insert(3, "C#");
            Console.WriteLine("插入C#后的字符串为：" + str4);

            //(5)
            string str5 = str4.Replace("C#", "Java");

            //(6)
            string[] strArr = str5.Split('c');
            for (int i = 0; i<strArr.Length; i++) {
                Console.WriteLine(strArr[i]);
            }

            //(7)
            string path = @"C:\test.txt";
            if (File.Exists(path)) {
                File.Delete(path);
            }
            
            File.WriteAllLines(path, strArr, Encoding.Default);
            

            //(8)
            File.AppendAllText(path, "Hello Word", Encoding.Default);

            //(9)
            Console.WriteLine("(9):" + File.ReadAllText(path, Encoding.Default));
            Console.ReadKey();
        }
    }
}
