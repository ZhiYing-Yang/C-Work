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

namespace A7
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            using (var context = new DatabaseTestEntities1())
            {
                var q = from t1 in context.Student
                        from t2 in context.Subject
                        where t1.专业编码 == t2.编码
                       
                        select new
                        {
                            学号 = t1.学号,
                            姓名 = t1.姓名,
                            性别 = t1.性别,
                            专业 = t2.名称,
                            宿舍 = t1.宿舍号
                        };
                dataGrid1.ItemsSource = q.ToList();

                var q1 = from t2 in context.Domitory
                         where t2.成员数 < 4
                         select new
                         {
                             宿舍 = t2.宿舍号,
                             学院 = t2.所属院系,
                             成员数 = t2.成员数,
                             床位上限 = t2.人数上限
                         };

                dataGrid2.ItemsSource = q1.ToList();
            }
        }
    }
}
