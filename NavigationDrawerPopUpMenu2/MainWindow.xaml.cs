using Agendar.User_Control;
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

namespace NavigationDrawerPopUpMenu2
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, RoutedEventArgs e)
        {

            Close();
            Environment.Exit(0);

            this.Hide();
            Login jan2 = new Login();
            jan2.Show();
        }
        private void BtnLogOut_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Login jan2 = new Login();
            jan2.Show();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemHome":
                    usc = new UserControlHome();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemCalendario":
                    usc = new UserControlCalendario();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemReserva":
                    usc = new UserControlReserva();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemStatus":
                    usc = new UserControlStatus();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemHorario":
                    usc = new UserControlHorario();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemRelatorio":
                    usc = new UserControlRelatorio();
                    GridMain.Children.Add(usc);
                    break;
                case "ItemBranco":
                    usc = new UserControlBranco();
                    GridMain.Children.Add(usc);
                    break;
                default:
                    break;
            }
        }

        private void BtnUsuarioClick(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            usc = new UserControlUsuario();
            GridMain.Children.Add(usc);
           
        }

        private void BtnSobreClick(object sender, RoutedEventArgs e)
        {
            UserControl usc = null;
            GridMain.Children.Clear();

            usc = new UserControlSobre();
            GridMain.Children.Add(usc);


        }
    }
}
