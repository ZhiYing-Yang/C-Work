using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Write("请输入用逗号分割的5个整数：");
                var str = Console.ReadLine();
                try
                {
                    string[] strArr = str.Split(',');
                    if (strArr.Length == 5)
                    {
                        int[] intArr = new int[5];
                        for (int i=0; i<5; i++) {
                            intArr[i] = int.Parse(strArr[i]);
                        }
                        Array.Sort(intArr);
                        Console.Write("正序：");
                        for (int i=0; i<intArr.Length; i++) {
                            Console.Write(intArr[i] +"  ");
                        }
                        Console.WriteLine();
                        Array.Reverse(intArr);
                        Console.Write("逆序：");
                        for (int i = 0; i < intArr.Length; i++)
                        {
                            Console.Write(intArr[i] + "  ");
                        }
                        Console.WriteLine();
                        Console.WriteLine("平均值："+intArr.Average());
                        Console.WriteLine("最大值："+intArr.Max());
                        Console.WriteLine("按回车键退出，其他键继续");
                        var temp = Console.ReadKey();
                        char key = temp.KeyChar;
                        if (key.Equals('\r')) {
                            break;
                        }
                    }
                    else {
                        Console.WriteLine("输入错误，请重新输入");
                    }
                }
                catch {
                }
            }
        }
    }
}
