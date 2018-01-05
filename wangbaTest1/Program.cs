using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wangbaTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            //(1)
            string str;
            while (true) {
                str = Console.ReadLine();
                if (str == "q" || str == "Q"){
                    break;
                }

                //(2)
                if (str.Length < 5)
                {
                    Console.WriteLine("必须至少输入5个字符");
                }else {
                    break;
                }
            }

            //（3.a）
            Console.WriteLine("字符串的长度为："+ str.Length);

            //(3.b)
            int count = 0;
            int startIndex = 0;
            while (true) {
                int y = str.IndexOf("ab", startIndex);
                if (y != -1)
                {
                    startIndex = y + 1;
                    count++;
                }
                else {
                    break;
                }
            }
            Console.WriteLine("字符串中 ab 的个数为：" + count);

            //(3.c)
            if (str.IndexOf("123") == -1)
            {
                Console.WriteLine("字符串中不包含123");
            }
            else {
                str = str.Replace("123", "abc");
                Console.WriteLine("替换后的字符串为：" + str);
            }

            //（3.d）
            Console.WriteLine(str.Insert(2, "me"));

            Console.ReadKey();
        }
    }
}
