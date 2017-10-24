using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace T5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入5个大写字母:");
            string a = Console.ReadLine();
            while (true)
            {
                if (Regex.IsMatch(a, "[^A-Z]"))
                {
                    Console.WriteLine("你输入的字符中有非大写字母，请重新输入：");
                    a = Console.ReadLine();
                }
                else if (a.Length != 5) {
                    Console.WriteLine("你输入大写字母的个数不为5，请重新输入：");
                    a = Console.ReadLine();
                }
                else
                {
                    break;
                }  
            }
            Console.WriteLine("输入成功，请按任意键退出。");
            Console.ReadKey();
        }
    }
}
