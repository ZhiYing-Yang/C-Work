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

namespace A_5_1_b
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private string str=null;
        public MainWindow()
        {
            InitializeComponent();
            autoButton.Click += AutoButton_Click;
            boxButton.Click += BoxButton_Click;
            windowButton.Click += WindowButton_Click;
        }

        private void WindowButton_Click(object sender, RoutedEventArgs e)
        {
            this.str = nameText.Text + "*" + essentialText.Text + "*" + otherText.Text;
            if (str.Length<3)
            {
                NewWindow n = new NewWindow("你没有输入任何信息", "", "");
            }
            else {

            }
        }

        private void BoxButton_Click(object sender, RoutedEventArgs e)
        {
            this.str = nameText.Text + "*" + essentialText.Text + "*" + otherText.Text;
            MessageBox.Show(str);
        }

        private void AutoButton_Click(object sender, RoutedEventArgs e)
        {
            nameText.Text = "王八";
            essentialText.Text = "男";
            otherText.Text = "1997-10-25";
        }
    }
}
