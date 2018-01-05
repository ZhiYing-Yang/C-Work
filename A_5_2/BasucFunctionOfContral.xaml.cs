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
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// BasucFunctionOfContral.xaml 的交互逻辑
    /// </summary>
    public partial class BasucFunctionOfContral : Window
    {
        public BasucFunctionOfContral()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = textbox.Text;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (textbox1.FontSize == 10)
            {
                textbox1.FontSize = 15;
                btn2.IsEnabled = true;
            }
            else
            {
                textbox1.FontSize = 20;
                btn1.IsEnabled = false;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (textbox1.FontSize == 20)
            {
                textbox1.FontSize = 15;
                btn1.IsEnabled = true;
            }
            else
            {
                textbox1.FontSize = 10;
                btn2.IsEnabled = false;
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Random ra = new Random();
            SolidColorBrush scb = new SolidColorBrush();
            byte r = (byte)ra.Next(256);
            byte g = (byte)ra.Next(256);
            byte b = (byte)ra.Next(256);
            scb.Color = Color.FromArgb(255,r,g,b);
            textbox1.Foreground = scb;
        }
    }
}
