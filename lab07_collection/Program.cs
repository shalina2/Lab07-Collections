using System;
using System.Linq;
using System.Collections.Generic; 

namespace lab07_collection
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            Console.WriteLine("Time to play");

            Deck<Card> Deck = new Deck<Card>();
            Card card1 = new Card("7", Card.Type.Diamonds);

            Card card2 = new Card("2", Card.Type.Hearts);

            Card card3 = new Card("10", Card.Type.Clubs);

            Card card4 = new Card("2", Card.Type.Spades);

            Card card5 = new Card("A", Card.Type.Spades);

            Card card6 = new Card("Ace", Card.Type.Diamonds);

            Deck.Add(card1);

            Deck.Add(card2);

            Deck.Add(card3);

            Deck.Add(card4);

            Deck.Add(card5);

            Deck.Add(card6);

            Console.WriteLine("your card is:");

            foreach (Card item in Deck)

            {
                Console.Write($"{item.CardNum} {item.type} ");
            }
            Console.WriteLine("      ");
            Console.WriteLine("      ");

            
            /////////////////remove
            Card[] newarray = Deck.Remove(card4);

            Console.WriteLine($"Removing {card4.CardNum} {card4.type}");



            Console.WriteLine("      ");

            Console.WriteLine($"Cards left:  {Deck.Count()}");

            

            foreach (Card item in newarray)

            {

                if (item != null)

                    Console.Write($"{item.CardNum} {item.type} ");

            }

            Console.WriteLine("  ");

            Console.WriteLine("  ");

            Console.WriteLine("  ");

            Console.WriteLine(" Would you like to start game?y/n ");

            string input = Console.ReadLine();

            string input1 = input.ToLower();

            if (input1 == "y")

            {

                Console.WriteLine("  ");

                Deal();

            }

            else Environment.Exit(0);

        }

        public static void Deal()

        {

            Deck<Card> player1 = new Deck<Card>();

            Deck<Card> player2 = new Deck<Card>();

            Deck<Card> dealerDeck = new Deck<Card>();

            Card card1 = new Card("Ace", Card.Type.Diamonds);

            Card card2 = new Card("J", Card.Type .Hearts);

            Card card3 = new Card("Q", Card.Type.Clubs);

            Card card4 = new Card("10", Card.Type.Spades);

            Card card5 = new Card("6", Card.Type .Spades);

            dealerDeck.Add(card1);

            dealerDeck.Add(card2);

            dealerDeck.Add(card3);

            dealerDeck.Add(card4);

            dealerDeck.Add(card5);

            Console.WriteLine("Player 1  Deck:   Empty ");

            Console.WriteLine("Player 2  Deck:   Empty ");

            Console.Write("Dealer Deck: ");

            foreach (Card item in dealerDeck)

            {

                Console.Write($"{item.CardNum} {item.type } ");

            }

            Console.WriteLine("          ");

            Console.WriteLine("          ");

            Console.WriteLine("(Distributing Deck)");

            Console.WriteLine("          ");

            Console.WriteLine("          ");



            player1.Add(card1);

            player1.Add(card2);

            player2.Add(card5);

            player2.Add(card4);

            dealerDeck.Remove(card1);

            dealerDeck.Remove(card2);

            dealerDeck.Remove(card5);

            dealerDeck.Remove(card4);


            Console.Write("Player 1 Deck: ");

            foreach (Card item in player1)

            {

                Console.Write($"{item.CardNum} {item.type } ");

            }

            Console.WriteLine("          ");

            Console.Write("Player 2 Deck: ");

            foreach (Card item in player2)

            {

                Console.Write($"{item.CardNum} {item.type} ");

            }

            Console.WriteLine("          ");

            Console.Write("Dealer Deck: ");

            foreach (Card item in dealerDeck)

            {

                if (item != null)

                    Console.Write($"{item.CardNum} {item.type} ");

            }

            Console.WriteLine("          ");
        }

    }

}
        
    

