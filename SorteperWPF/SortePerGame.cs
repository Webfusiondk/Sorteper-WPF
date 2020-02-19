using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SorteperWPF.PlayerFolder;

namespace SorteperWPF
{
    class SortePerGame
    {

        public void GiveCardsToPlayers(List<Player> players, List<SortePerCard> deck)
        {
            int playercount = players.Count;
            foreach (var card in deck)
            {
                if (playercount == players.Count)
                    playercount = 0;

                players[playercount].Hand.Add(card);
                playercount++;
            }
        }

        public void CheckForPari(Player curentPlayer)
        {
            foreach (Card card in curentPlayer.Hand.ToList())
            {
                foreach (Card cards in curentPlayer.Hand.ToList())
                {
                    if (card.Value == cards.Value && card.Id != cards.Id)
                    {
                        curentPlayer.Hand.Remove(card);
                        curentPlayer.Hand.Remove(cards);

                    }
                }
            }
        }

        //public void TakeCard(Player CurentPlayer, Player NextPlayer)
        //{
        //    Card tempCard = NextPlayer.Hand;
        //    CurentPlayer.Hand.Add(tempCard);
        //    NextPlayer.Hand.Remove(tempCard);
        //}

        //Adds a player to the game

        public bool Win(List<Player> players)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Hand.Count == 0)
                    players.Remove(players[i]);
            }

            if (players.Count == 1)
                return true;
            return false;
        }
    }
}
