using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T6
{
    class Program
    {
        static void Main(string[] args)
        {
            check:
            Console.Write("请输入一个整数：");
            var a= Console.ReadLine();
            try
            {
                int num = int.Parse(a);
                if (num > 0)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        Console.Write(i + "  ");
                    }
                    Console.WriteLine();
                    goto check;
                }
                else if (num < 0)
                {
                    return;
                }
                else {
                    goto check;
                }
            }
            catch {
                Console.WriteLine("您输入的不是整数");
                goto check;
            }
            Console.WriteLine("按任意键退出");
            Console.ReadKey();
        }

    }
}
