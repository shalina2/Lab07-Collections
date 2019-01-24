using System;
using System.Collections.Generic;
using System.Text;

namespace lab07_collection
{
    public class Card
    {
        public enum Type { Diamonds,Hearts,Spades,Clubs }
        public string CardNum { get; set; }
        public Type type { get; set; }

        public Card(String cardNumber,Type  suitName)
        {
            CardNum = cardNumber;
            type = suitName;
        }
    }
}
