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

namespace A_5_1
{
    /// <summary>
    /// Login.xaml 的交互逻辑
    /// </summary>
    public partial class Login : Window
    {
        private static int loginTime = 0;
        private Boolean status = false;
        private string username;
        public Login()
        {
            InitializeComponent();
            loginButton.Click += LoginButton_Click;
            cancleButton.Click += CancleButton_Click;
            this.Closing += Login_Closing;
        }

        public string getUsername() {
            return this.username;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string identity = identityCom.Text;
            string password;
            if (identity == "普通用户")
            {
                 password = "abcabc";
            }
            else {
                password = "123abc";
            }
            if (usernameText.Text == "764000395" && passwordText.Password == password)
            {
                this.status = true;
                this.username = usernameText.Text;
                this.Close();
            }
            else {
                MessageBox.Show("用户名或密码错误，请重新登录", "错误");
                loginTime++;
                if (loginTime >= 3)
                {
                    App.Current.Shutdown();
                    return;
                }
            }

        }

        private void CancleButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Login_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!status) {
                App.Current.Shutdown();
            }
        }
    }
}
