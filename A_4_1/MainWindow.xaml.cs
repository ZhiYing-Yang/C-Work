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

namespace A._4._1
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
        StringBuilder str = new StringBuilder();
        List<Person> person = new List<Person>()
        {
            new Person {name="张三丰",Age=21,PhoneNumber="13037853201" },
            new Person {name="李四明",Age=18,PhoneNumber="13537812345" },
            new Person {name="赵六方",Age=19,PhoneNumber="15228680218" },
            new Person {name="王五新",Age=20,PhoneNumber="15222873156" },
            new Person {name="李一鸣",Age=24,PhoneNumber="15923456798" }
        };
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            str.Clear();
            str.Append(string.Format("{0,-20}{1,-10}{2,-20}\n", "姓名", "年龄", "手机号码"));
            RadioButton btn = (RadioButton)e.Source;
            if (btn.Tag.Equals("b1"))
            {
                foreach (var p in person)
                {
                    str.AppendLine(p.Print());
                }
            }
            else if (btn.Tag.Equals("b2"))
            {
                var per = from t in person
                        where t.Age >= 18 && t.Age <= 25
                        select t;
                foreach (var p in per)
                {
                    str.AppendLine(p.Print());
                }
            }
            else if(btn.Tag.Equals("b3")   )
            {
                var per = from t in person
                          where t.name.StartsWith("李")
                          select t;
                foreach (var p in per)
                {
                    str.AppendLine(p.Print());
                }
            }
            textBlock.Text = str+"";
        }
    }
}
