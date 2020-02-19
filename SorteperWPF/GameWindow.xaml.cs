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
    public partial class GameWindow : Window
    {
        public Game currentGame = new Game();
        Image image = new Image();
        public GameWindow(Game cg)
        {
            InitializeComponent();
            currentGame = cg;
            currentGame.Start();
            SetNamesOnLabel();
            GetImageOfCard();
        }

        void GetImageOfCard()
        {
         ImageCard source = new ImageCard();
            for (int i = 0; i < currentGame.players.Count; i++)
            {
                if (i == 0)
                {
                    int pos = 20;
                    foreach (var card in currentGame.players[i].Hand)
                    {
                        Image cardImg = new Image();

                        cardImg.Source = source.BitmapInIt(card.Value);
                        cardImg.Width = 120;
                        cardImg.Height = 120;
                        

                        BottomCanvas.Children.Add(cardImg);
                        Canvas.SetLeft(cardImg, pos);
                        pos = pos + 20;
                    }
                }

                else if (i == 1)
                {
                    int pos = 20;
                    foreach (var card in currentGame.players[i].Hand)
                    {
                        Image cardImg = new Image();

                        cardImg.Source = source.BitmapInIt(card.Value);
                        cardImg.Width = 120;
                        cardImg.Height = 120;

                        TopCanvas.Children.Add(cardImg);
                        Canvas.SetLeft(cardImg, pos);
                        pos = pos + 20;
                    }
                }

                else if (i == 2)
                {
                    int pos = 20;
                    foreach (var card in currentGame.players[i].Hand)
                    {
                        Image cardImg = new Image();

                        cardImg.Source = source.BitmapInIt(card.Value);
                        cardImg.Width = 120;
                        cardImg.Height = 120;

                        RightCanvas.Children.Add(cardImg);
                        Canvas.SetLeft(cardImg, pos);
                        pos = pos + 20;
                    }
                }

                else
                {
                    int pos = 20;
                    foreach (var card in currentGame.players[i].Hand)
                    {
                        Image cardImg = new Image();

                        cardImg.Source = source.BitmapInIt(card.Value);
                        cardImg.Width = 120;
                        cardImg.Height = 120;

                        LeftCanvas.Children.Add(cardImg);
                        Canvas.SetLeft(cardImg, pos);
                        pos = pos + 20;
                    }
                }
            }
        }

        void SetNamesOnLabel()
        {
            for (int i = 0; i < currentGame.players.Count; i++)
            {
                if (i == 0)
                {
                    BottomName.Content = currentGame.players[i].Name;
                }

                else if (i == 1)
                {
                    TopName.Content = currentGame.players[i].Name;
                }

                else if (i == 2)
                {
                    RightName.Content = currentGame.players[i].Name;
                }

                else
                {
                    LeftName.Content = currentGame.players[i].Name;
                }
            }
        }
    }
}
