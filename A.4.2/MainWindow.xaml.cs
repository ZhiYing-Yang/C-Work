using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace A._4._2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        string path = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                textBox1.Text=ofd.FileName;//文件的路径
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            try
            {
                path = textBox1.Text;
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
                while (sr.Peek() != -1)
                {
                    textBox.Text += sr.ReadLine() + "\n";
                }
                sr.Close();
            }
            catch (Exception)
            {
                textBox.Text += "路径有误\n";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            if (textBox.Text!="")
            {
                try
                {
                    path = textBox1.Text;
                    StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                    sw.Write(textBox.Text.ToString());
                    sw.Close();
                    MessageBox.Show("保存成功！");
                }
                catch (Exception)
                {
                   textBox.Text = "路径有误\n";
                }

            }
        }
    }
}
