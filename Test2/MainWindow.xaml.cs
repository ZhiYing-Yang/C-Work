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

namespace Test2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SourceInitialized += MainWindow_SourceInitialized;
            bigButton.Click += BigButton_Click;
            smallButton.Click += SmallButton_Click;
            colorButton.Click += ColorButton_Click;
        }

        private void ColorButton_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush wordcolor = new SolidColorBrush();
            wordcolor.Color = Color.FromArgb(255, (byte)redSlider.Value, (byte)greenSlider.Value, (byte)blueSlider.Value);
            actionWords.Foreground = wordcolor;
        }

        private void SmallButton_Click(object sender, RoutedEventArgs e)
        {
            if (actionWords.FontSize > 5) {
                actionWords.FontSize -= 1;
            }
        }

        private void BigButton_Click(object sender, RoutedEventArgs e)
        {
            if (actionWords.FontSize < 20) {
                actionWords.FontSize += 1;
            }
        }

        private void MainWindow_SourceInitialized(object sender, EventArgs e)
        {
            LoginWindow l = new LoginWindow();
            l.ShowDialog();
        }
    }
}
