using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteperWPF.PlayerFolder
{
    public class Player
    {
        public string Name { get; set; }
        private List<Card> hand;

        public List<Card> Hand
        {
            get { return hand; }
            set { hand = value; }
        }

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();

        }
    }
}
