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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button;
            Window w;
            if (btn.Content.ToString()== "ClicksCounter")
            {
                 w = new ClicksCounter();
            }
            else if (btn.Content.ToString() == "MoveTesting")
            {
                 w = new MoveTesting();
            }
            else
            {
                 w = new BasucFunctionOfContral();
            }
            w.Show();
        }
    }
}
