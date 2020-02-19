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

namespace SorteperWPF
{
    /// <summary>
    /// Interaction logic for PreGameWindow.xaml
    /// </summary>
    public partial class PreGameWindow : Window
    {
        private Game currentGame = new Game();

        public int amount;
        public PreGameWindow()
        {
            InitializeComponent();
        }

        public void HideButton()
        {
            B2Player.Visibility = Visibility.Collapsed;
            B3Player.Visibility = Visibility.Collapsed;
            B4Player.Visibility = Visibility.Collapsed;
            NameBox.Visibility = Visibility.Visible;
            Submit.Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HideButton();
            amount = 2;
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            HideButton();
            amount = 3;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            HideButton();
            amount = 4;
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            AddPlayer();
        }

        void AddPlayer()
        {
            if (currentGame.players.Count < amount)
            {
                currentGame.AddPlayer(NameBox.Text);
                PlayerNames.Children.Add(new Label { Content = "Player " + currentGame.players.Count + ": " + NameBox.Text + " " });
                NameBox.Text = "";
            }

            if (currentGame.players.Count == amount)
            {
                //Make it to a method later
                NameBox.Visibility = Visibility.Collapsed;
                Submit.Visibility = Visibility.Collapsed;
                StartButton.Visibility = Visibility.Visible;
            }
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            GameWindow GW = new GameWindow(currentGame);
            App.Current.MainWindow = GW;
           
            this.Hide();
            GW.WindowState = WindowState.Maximized;
            GW.Show();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                AddPlayer();
            }
        }
    }
}
