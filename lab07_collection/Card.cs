using System;
using System.Collections.Generic;
using System.Text;

namespace lab07_collection
{
    public class Card
    {
        public enum Suits { Diamonds,Hearts,Spades,Clubs }
        public string CardNum { get; set; }
        public Suits suit { get; set; }

        public Card(String cardNumber,Suits suitName)
        {
            CardNum = cardNumber;
            suit = suitName;
        }
    }
}
