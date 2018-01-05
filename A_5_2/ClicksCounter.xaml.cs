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
    /// ClicksCounter.xaml 的交互逻辑
    /// </summary>
    public partial class ClicksCounter : Window
    {
        private int num = 0;
        public ClicksCounter()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            num++;
            lable.Content = String.Format("第{0}次点击",num);
        }
    }
}
