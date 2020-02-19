using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SorteperWPF.PlayerFolder;

namespace SorteperWPF
{
    public class Game
    {
        public List<Player> players = new List<Player> ();
        SortePerGame SPG = new SortePerGame();
        FactoryDeck FD = new FactoryDeck();
        public void Start()
        {
            SPG.GiveCardsToPlayers(players,FD.CreateSortePerCards());
        }

        public void AddPlayer(string name)
        {
            players.Add(new Player(name));
        }
    }
}
