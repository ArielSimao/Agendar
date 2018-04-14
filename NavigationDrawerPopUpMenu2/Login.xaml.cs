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

namespace NavigationDrawerPopUpMenu2
{
    /// <summary>
    /// Lógica interna para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow jan2 = new MainWindow();
            jan2.Show();
        }
        private void BtnSair(object sender, RoutedEventArgs e)
        {
            Close();
            Environment.Exit(0);
        }

        private void BtnSairClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
