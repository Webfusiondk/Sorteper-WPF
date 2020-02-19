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

namespace SorteperWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowState = WindowState.Maximized;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PreGameWindow PGW = new PreGameWindow();
            App.Current.MainWindow = PGW;
            PGW.WindowState = WindowState.Maximized;
            this.Hide();
            PGW.Show();
        }
    }
}
