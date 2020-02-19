using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteperWPF
{
    class FactoryDeck
    {
        public List<SortePerCard> CreateSortePerCards()
        {
            List<SortePerCard> SPCard = new List<SortePerCard>()
            {
                new SortePerCard("bear",1),
                new SortePerCard("bee",2),
                new SortePerCard("bull",3),
                new SortePerCard("camel",4),
                new SortePerCard("cat",5),
                new SortePerCard("crab",6),
                new SortePerCard("crocodile",7),
                new SortePerCard("dog",8),
                new SortePerCard("duck",9),
                new SortePerCard("fish",10),
                new SortePerCard("grasshopper",11),
                new SortePerCard("ladybug",12),
                new SortePerCard("mouse",13),
                new SortePerCard("ostrich",14),
                new SortePerCard("panda",15),
                new SortePerCard("bear",16),
                new SortePerCard("bee",17),
                new SortePerCard("bull",18),
                new SortePerCard("camel",19),
                new SortePerCard("cat",20),
                new SortePerCard("crab",21),
                new SortePerCard("crocodile",22),
                new SortePerCard("dog",23),
                new SortePerCard("duck",24),
                new SortePerCard("fish",25),
                new SortePerCard("grasshopper",26),
                new SortePerCard("ladybug",27),
                new SortePerCard("mouse",28),
                new SortePerCard("ostrich",29),
                new SortePerCard("panda",30),
                new SortePerCard("sheep",31)
            };
            return ShuffelCards(SPCard);
        }

        public List<SortePerCard> ShuffelCards(List<SortePerCard> cards)
        {
            //Shuffling the list of cards with the Fisher-Yates method.
            Random r = new Random(DateTime.Now.Millisecond);
            for (int n = cards.Count - 1; n > 0; --n)
            {
                //Random picks a card that has not been suffeld
                int k = r.Next(n + 1);

                //Swap the selected card with the last "Unselected" Card in the list
                SortePerCard temp = cards[n];
                cards[n] = cards[k];
                cards[k] = temp;
            }
            return cards;
        }
    }
}
