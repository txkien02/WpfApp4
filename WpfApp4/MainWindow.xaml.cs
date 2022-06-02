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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tb_username_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tb_username.Text.Length > 0)
            {
                tb_watermark.Visibility = Visibility.Collapsed;
            }
            else
            {
                tb_watermark.Visibility = Visibility.Visible;
            }
        }

        private void pwb_password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (pwb_password.Password.Length > 0)
            {
                tb_watermarkpw.Visibility = Visibility.Collapsed;
            }
            else
            {
                tb_watermarkpw.Visibility = Visibility.Visible;
            }
            
        }

        private void btn_register_Click(object sender, RoutedEventArgs e)
        {
            repass.Visibility = Visibility.Visible;
            pwb_repassword.FontSize = 15;
            pwb_repassword.VerticalContentAlignment = VerticalAlignment.Center;
            pwb_repassword.Visibility = Visibility.Visible;
            pwb_repassword.Height = 36.25;
            pwb_repassword.Width = 237.5;

            tb_watermarkrpw.Visibility = Visibility.Visible;

            cb_remember.Visibility = Visibility.Hidden;
            cb_remember.Height = 0; cb_remember.Width = 0;

            btn_login.Visibility = Visibility.Hidden;
            btn_login.Height = 0;
            btn_login.Width = 0;
            btn_login.Margin = new Thickness(0, 0, 0, 0);

            btn_Registration.Background = null;
            btn_Registration.FontSize = 15;
            btn_Registration.Visibility = Visibility.Visible;
            btn_Registration.Height = 54.87916666666663;
            btn_Registration.Width = 237.5;

            btn_register.Visibility = Visibility.Hidden;
            btn_register.Height = 0;
            btn_register.Width = 0;

            btn_Login.Background = null;
            btn_Login.FontSize = 15;
            btn_Login.Width = 237.5;
            btn_Login.Height = 29.9375;
            btn_Login.Visibility = Visibility.Visible;

            tb_reshowpass.Visibility = Visibility.Collapsed;
            btn_showr.Visibility = Visibility.Visible;
            btn_showr.Height = 29.9375;
            btn_showr.Width = 29.9375;
            btn_hider.Visibility = Visibility.Collapsed;




        }



        private void btn_Login_Click(object sender, RoutedEventArgs e)
        {
            repass.Visibility = Visibility.Collapsed;
            pwb_password.Visibility = Visibility.Visible;
            pwb_password.Height = 36.25;
            pwb_password.Width = 237.5;

            pwb_repassword.Visibility = Visibility.Hidden;
            pwb_repassword.Height = 0;
            pwb_repassword.Width = 0;

            tb_watermarkrpw.Visibility = Visibility.Hidden;

            cb_remember.Visibility = Visibility.Visible;
            cb_remember.Width = 237.5;
            cb_remember.Height = 17;

            btn_Registration.Visibility = Visibility.Hidden;
            btn_Registration.Height = 0;
            btn_Registration.Width = 0;
            btn_Registration.Margin = new Thickness(0, 0, 0, 0);

            btn_login.Margin = new Thickness(0, 0, 0, 5);
            btn_login.Visibility = Visibility.Visible;
            btn_login.Height = 54.87916666666663;
            btn_login.Width = 237.5;

            btn_Login.Visibility = Visibility.Hidden;
            btn_Login.Height = 0;
            btn_Login.Width = 0;

            btn_register.Width = 237.5;
            btn_register.Height = 29.9375;
            btn_register.Visibility = Visibility.Visible;

            btn_showr.Visibility = Visibility.Visible;
            btn_hider.Visibility = Visibility.Collapsed;
            pwb_repassword.Password = "";
            tb_reshowpass.Text = "";



        }

        private void pwb_repassword_PasswordChanged2(object sender, RoutedEventArgs e)
        {
            if (pwb_repassword.Password.Length > 0)
            {
                tb_watermarkrpw.Visibility = Visibility.Collapsed;
            }
            else
            {
                tb_watermarkrpw.Visibility = Visibility.Visible;
            }
        }

        private void btn_hide_Click(object sender, RoutedEventArgs e)
        {
            btn_hide.Height = 0;
            btn_hide.Width = 0;
            btn_show.Visibility = Visibility.Visible;
            btn_show.Height = 36.7;
            btn_show.Width = 30;
            pwb_password.Visibility = Visibility.Visible;
            tb_showpass.Visibility = Visibility.Hidden;
        }

        private void btn_show_Click(object sender, RoutedEventArgs e)
        {
            btn_hide.Visibility = Visibility.Visible;
            btn_hide.Height = 36.7;
            btn_hide.Width = 30;
            btn_show.Height = 0;
            btn_show.Width = 0;
            tb_showpass.Visibility = Visibility.Visible;
            pwb_password.Visibility = Visibility.Hidden;
            tb_showpass.Text = pwb_password.Password;

        }

        

        private void tb_showpass_TextChanged(object sender, TextChangedEventArgs e)
        {
            pwb_password.Password = tb_showpass.Text;


        }

        private void btn_hider_Click(object sender, RoutedEventArgs e)
        {
            btn_hider.Height = 0;
            btn_hider.Width = 0;
            btn_showr.Visibility = Visibility.Visible;
            btn_showr.Height = 36.7;
            btn_showr.Width = 30;
            pwb_repassword.Visibility = Visibility.Visible;
            tb_reshowpass.Visibility = Visibility.Hidden;
        }

        private void btn_showr_Click(object sender, RoutedEventArgs e)
        {
            btn_hider.Visibility = Visibility.Visible;
            btn_hider.Height = 36.7;
            btn_hider.Width = 30;
            btn_showr.Height = 0;
            btn_showr.Width = 0;
            tb_reshowpass.Visibility = Visibility.Visible;
            pwb_repassword.Visibility = Visibility.Hidden;
            tb_reshowpass.Text = pwb_repassword.Password;
        }

        private void tb_reshowpass_TextChanged(object sender, TextChangedEventArgs e)
        {
            pwb_repassword.Password = tb_reshowpass.Text;
        }
    }
}
