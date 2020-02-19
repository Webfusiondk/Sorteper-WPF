using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorteperWPF
{
    public abstract class Card
    {
        public string Value { get; set; }
        public int Id { get; set; }
        public Card(string value, int cardID)
        {
            Id = cardID;
            Value = value;
        }

        protected Card(string value)
        {
            Value = value;
        }
    }
}
