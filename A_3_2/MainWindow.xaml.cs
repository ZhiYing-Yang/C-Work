using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Diagnostics;
//引入wpf中用的定时器
using System.Windows.Threading;

namespace A_3_2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            start.Click += delegate
            {
                if (shi.IsChecked == true)
                {
                    result.Content = "随机生成实数功能暂未实现";
                }
                else {
                    try {
                        int min = int.Parse(minText.Text);
                        int max = int.Parse(maxText.Text);
                        //int interval;
                        if (!int.TryParse(intervalText.Text, out int interval)) {
                            result.Content = "时间间隔应为正整数，请重新输入。";
                            return;
                        }
                        if ( max < min ) {
                            result.Content = "最小范围大于最大范围，\n请重新输入生成随机数的范围";
                            return;
                        }
                        
                        timer.Interval = new TimeSpan(interval);
                        timer.Start();
                        timer.Tick += delegate {
                            result.Content = RandomHelp.getIntRandomNumber(min, max);
                        };

                        stop.Click += delegate {
                            timer.Stop();
                        };
                    }
                    catch (Exception e) {
                        result.Content = e.Source + "\n请重新设置随机数的范围";
                    }
                }

            };
        }
    }
}
