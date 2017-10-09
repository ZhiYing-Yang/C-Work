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

namespace A_2_2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            result.Content = "";
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e) {
            if (result.Content == null) {
                return;
            }
            result.Content = "";
            string s = (e.Source as RadioButton).Content.ToString();
            operatorZi.Content = s;
            string s1 = "";
            switch (s)
            {
                case "加法": s1 = "+"; break;
                case "减法": s1 = "-"; break;
                case "乘法": s1 = "*"; break;
                case "除法": s1 = "/"; break;
                case "取模": s1 = "%"; break;
            }
            operatorFu.Content = s1;
        }

        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            double n1, n2;
            if (double.TryParse(first.Text, out n1)==false || double.TryParse(second.Text, out n2)==false) {
                result.Content = "?";
                return;
            }
            string s = operatorFu.Content.ToString();
            switch (s)
            {
                case "+":
                    result.Content = string.Format("{0:0.####}", n1+n2);
                    break;
                case "-":
                    result.Content = string.Format("{0:0.####}", n1 - n2);
                    break;
                case "*":
                    result.Content = string.Format("{0:0.####}", n1 * n2);
                    break;
                case "/":
                    if (n2 != 0)
                    {
                        result.Content = string.Format("{0:0.####}", n1 / n2);
                    }
                    else {
                        result.Content = "分母不能为0";
                    }
                    
                    break;
                case "%":
                    if (n2 != 0)
                    {
                        result.Content = string.Format("{0:0.####}", n1 % n2);
                    }
                    else
                    {
                        result.Content = "分母不能为0";
                    }
                    break;
            }
        }
    }
}
