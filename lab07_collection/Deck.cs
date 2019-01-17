using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab07_collection
{
    public class Deck<T>: IEnumerable<T> where T : Card
    {
        /// <summary>
    /// to see the number of card  in the game
    /// </summary>
        T[] cards = new T[54];
        int currentIndex = 0;
        int counter = 0;

        public void Add(T item)
        {
            if (currentIndex > cards.Length - 1)
            {
                Array.Resize(ref cards, cards.Length * 3);
            }
            cards[currentIndex] = item;
            currentIndex++;
            counter++;
        }

      public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                yield return cards[i];
            }
         }
        /// <summary>
         /// process of removing card from the deck
         /// </summary>
         /// <param name="item"></param>
         /// <returns></returns>
         /// 
        public T[] Remove(T item)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == item)
                {
                    int index = Array.IndexOf(cards, item);
                    counter--;

                    T[] newCards = cards.Where((Val, idx) => idx != index).ToArray();
                    Array.Copy(newCards, cards, newCards.Length);
                    return cards;
                }
            }
            Console.WriteLine("Not there");
            return null;
        }

            public int Count()
            {
                return counter;
            }
           
            
       
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
