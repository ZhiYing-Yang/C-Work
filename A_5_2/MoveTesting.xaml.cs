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
    /// MoveTesting.xaml 的交互逻辑
    /// </summary>
    public partial class MoveTesting : Window
    {
        public MoveTesting()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button;
            switch (btn.Content.ToString())
            {
                case "左移":
                    border.Margin = new Thickness(border.Margin.Left - 5, border.Margin.Top, 0, 0);
                    break;
                case "右移":
                    border.Margin = new Thickness(border.Margin.Left + 5, border.Margin.Top, 0, 0);
                    break;
                case "上移":
                    border.Margin = new Thickness(border.Margin.Left, border.Margin.Top - 5, 0, 0);
                    break;
                case "下移":
                    border.Margin = new Thickness(border.Margin.Left, border.Margin.Top + 5, 0, 0);
                    break;
                default:
                    break;
            }
        }
    }
}
