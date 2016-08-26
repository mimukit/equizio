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

namespace EQUIZIO
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            lblUserNameError.Visibility = Visibility.Hidden;
            lblPasswordError.Visibility = Visibility.Hidden;
            lblTypeError.Visibility = Visibility.Hidden;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUserName.Text;
            string userPassword = pbxUser.Password;
            int userType = cbxType.SelectedIndex;

            if (userName != "" && userPassword != "")
            {
                //TODO check db for login
            }
            else
            {
                if (userName == "")
                {
                    lblUserNameError.Visibility = Visibility.Visible;
                    lblUserNameError.Content = "User Name can't be blank";
                }
                if (userPassword == "")
                {
                    lblPasswordError.Content = "Password can't be blank";
                    lblPasswordError.Visibility = Visibility.Visible;
                }

                lblTypeError.Content = "Don't forget to check account type";
                lblTypeError.Visibility = Visibility.Visible;
            }


            MessageBox.Show("User Name: " + userName + "\n" + "Password: " + userPassword + "\nType: " + userType);

        }

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
