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

namespace Test2
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        private Boolean loginStatus = false;
        public LoginWindow()
        {
            InitializeComponent();
            loginButton.Click += LoginButton_Click;
            cancleButton.Click += CancleButton_Click;
            this.Closing += LoginWindow_Closing;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if ( (passwordText.Password == "admin" && identity.Text == "管理员") || (passwordText.Password == "userabc" && identity.Text == "一般用户") )
            {
                loginStatus = true;
                this.Close();
            }
            else {
                MessageBox.Show("用户名或密码错误", "错误");
            }
        }

        private void CancleButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoginWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!loginStatus) {
                App.Current.Shutdown();
            }
        }
    }
}
