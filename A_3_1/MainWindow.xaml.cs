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

namespace A_3_1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CourseInfo[] cArr = {
                new CourseInfo("数据结构", 0, "《数据结构》", 40),
                new CourseInfo("操作系统", 1, "《操作系统》", 45),
                new CourseInfo("软件工程", 0, "《软件工程》", 38)
            };
            foreach (CourseInfo v in cArr) {
                nameList.Items.Add(v.CourseName);
                timeList.Items.Add(v.Season);
                bookList.Items.Add(v.BookName);
                priceList.Items.Add(v.Price);
            }

        }
    }
}
