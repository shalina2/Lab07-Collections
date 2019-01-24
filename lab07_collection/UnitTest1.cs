using lab07_collection;
using System;
using Xunit;

namespace lab07collection
{
    public class UnitTest1
    {
        [Fact]
        public void addcard()
        {
            Deck<Card> Deck = new Deck<Card>();
            Card card1 = new Card("9", Card.Type.Spades );
            Deck.Add(card1);
            int a = Deck.Count();
            Assert.Equal(1, a);
        }
        [Fact]
        public void DontRemovecardwhenexists()
        {
            Deck<Card> Deck = new Deck<Card>();
            Card card1 = new Card("2", Card.Type.Diamonds);
            Card card2 = new Card("5", Card.Type.Hearts);
            Deck.Add(card1);
            Deck.Add(card2);
            Deck.Remove(card2);
            Assert.Null(Deck.Remove(card2));
            
        }
        [Fact]
        public void RemovewhenExist()
        {
            Deck<Card> Deck = new Deck<Card>();
            Card card1 = new Card("2", Card.Type.Diamonds);
            Card card2 = new Card("5", Card.Type.Hearts);
            Deck.Add(card1);
            Deck.Add(card2);
            Card[] expected = new Card[] { card1 };
            Assert.Equal(expected[0].CardNum, Deck.Remove(card2)[0].CardNum );
        }
        [Fact]
        public void getinfo()
        {
            Deck<Card> Deck = new Deck<Card>();
            Card card1 = new Card("3", Card.Type.Diamonds);
            Deck.Add(card1);
            Assert.Equal("3",card1.CardNum );


        }
    }
}
