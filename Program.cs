using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CALLING_METHODS_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            int timesshuffled = 0
            deck = Shuffle(deck: deck, out timesShuffled: 3);


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
                return deck;
            }
        }
    }
}