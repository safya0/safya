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

namespace Managment
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var corect = "Admin123";
                Management management = new Management();
                View view = new View();
                Userr userr = new Userr();
                var pass = Passwordtxt.Text;
                var em = Emailtxt;

                //if (Passwordtxt.Text == corect == userr.UserPassword)

                
                if (Passwordtxt.Text == corect)
                {
                        NavigationService.Navigate(management);
                        MessageBox.Show("Login Successfuly");
                }
                    if (userr.UserPassword == Passwordtxt.Text)
                    {
                        NavigationService.Navigate(view);
                        MessageBox.Show("Login Successfuly");

                    }
                
                MessageBox.Show("Error, Please Try Agign");

            }
            catch
            {
                MessageBox.Show("Error, Please Try Agign");
            }
        }
    }
}
