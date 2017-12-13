using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication4
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        int a, b;
        int time=25;
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        Random ra = new Random();
        string anw1, anw2, anw3, anw4;
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromMilliseconds(1000);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            time--;
            lab.Content = "剩余时间：" + time + "秒";
            if (time==0)
            {
                timer.Stop();
                submit();
            }
        }

        private void submit()
        {
            btn.IsEnabled = false;
            if (text1.Text == anw1 && text2.Text == anw2 && text3.Text == anw3 && text4.Text == anw4)
            {
                MessageBox.Show("恭喜，过关成功。");
            }
            else
            {
                MessageBox.Show("过关失败，请继续努力！");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            text1.Text = "";
            text2.Text = "";
            text3.Text = "";
            text4.Text = "";
            timer.Start();
            time = 25;
            btn.IsEnabled = true;
            getValue(100);
            anw1 = (a + b )+ "";
            lab1.Content = "1、 " + a + "+" + b + "=";

            getValue(100);
            anw2 = (a - b) + "";
            lab2.Content = "2、 " + a + "-" + b + "=";

            getValue(15);
            anw3 = (a * b) + "";
            lab3.Content = "3、 " + a + "×" + b + "=";

            a = ra.Next(100) + 1;
            b = ra.Next(a) + 2;
            while (a % b != 0)
            {
                a = ra.Next(100) + 1;
                b = ra.Next(a/2) + 2;
            }
                anw4 = (a / b) + "";
            lab4.Content = "4、 " + a + "÷" + b + "=";
         }

        private void getValue(int n)
        {
            a = ra.Next(n) + 1;
            b = ra.Next(n) + 1;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            submit();
        }
    }
}
