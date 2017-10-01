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
            Console.Write("请输入一个长度大于3的字符串:");
            string a = Console.ReadLine();
            while (true) {
                if (a.Length > 3)
                {
                    break;
                }
                else {
                    Console.WriteLine("你输入的字符串长度小于3,请重新输入：");
                    a = Console.ReadLine();
                }
            }
            Console.WriteLine("T3_1 该字符串的长度为："+a.Length);
            if (a.IndexOf("a") == -1) {
                Console.WriteLine("T3_2 该字符串中没有出现a");
            }
            else {
                Console.WriteLine("T3_2 出现字母a的位置为：{0}", a.IndexOf("a"));
            }
            Console.WriteLine("T3_3 新字符串为：{0}", a=a.Insert(2, "hello"));
            
            Console.WriteLine("T3_4 将hello替换成me后：{0}", a = a.Replace("hello", "me"));
            string[] aArray = a.Split('m');
            Console.WriteLine("T3_5 分割后的字符串为：");
            foreach (string i in aArray) {
                Console.WriteLine(i.ToString());
            }
            
            Console.WriteLine("按任意键退出");
            Console.ReadKey();
        }
    }
}
