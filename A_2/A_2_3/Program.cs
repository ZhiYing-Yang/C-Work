using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Write("请输入一个大于100的整数：");
                var str = Console.ReadLine();
                try
                {
                    int num = int.Parse(str);
                    if (num <= 100)
                    {
                        Console.WriteLine("你输入的数不大于100，请重新输入");
                    }
                    else {
                        Console.WriteLine("该整数共有{0}位。", str.Length);
                        int sum=0;
                        int[] arr = new int[str.Length];
                        for (int i=0; i<str.Length; i++) {
                            arr[i] = num % 10;
                            num /=10;
                            sum += arr[i];
                        }
                        Console.Write("实现思路1：每一位的值为");
                        for (int i=str.Length-1; i>=0; i--) {
                            Console.Write(arr[i]+", ");
                        }
                        Console.Write("这些位之和为"+sum);
                        Console.WriteLine();
                        Console.Write("实现思路2：每一位的值为");
                        int sum2 = 0;
                        for (int i=0; i<str.Length; i++) {
                            Console.Write(str[i]+", ");
                            //char类型不能直接转换成int类型  可 以string为桥梁转换   即int = int.Parse(char.toString())
                            sum2 += int.Parse(str[i].ToString());
                        }
                        Console.Write("这些位之和为"+sum2);
                        Console.WriteLine();
                        Console.WriteLine("按回车键退出，其他键继续！");

                        //读取用户键盘按键
                        var temp = Console.ReadKey();
                        char key = temp.KeyChar;
                        if (key.Equals('\r')) {
                            break;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("输入错误，请重新输入");
                }
            }
        }
    }
}
