using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt10
{
    internal class Deck
    {
        static List<Card> CurrentDeck;
        static int SizeOfDeck;

        public Deck() //konstruktor tworzący standardową talię 52 kart
        {
            SizeOfDeck = 52;
            CurrentDeck = new List<Card>(SizeOfDeck);
        }

        public List<Card> GetDeck()
        {
            return CurrentDeck;
        }
        public void MakeDefaultDeck()
        {
            Card newCard;
            for (int i = 2; i <= 14; i++)
            {
                newCard = new Card("hearts", i);//serca to z ang hearts
                CurrentDeck.Add(newCard);//dodajemy karte
                newCard = new Card("spades", i); // pik to z ang spades
                CurrentDeck.Add(newCard);//dodajemy karte
                newCard = new Card("diamonds", i); //karo to z ang diamonds
                CurrentDeck.Add(newCard);//dodajemy karte
                newCard = new Card("clubs", i); // trefl to z ang clubs
                CurrentDeck.Add(newCard);//dodajemy karte  
                //tak stworzona talia bedzie miala wszytskie figury
            }
        }

        public void Shuffle(List<Card> deck)
        {
            Random random = new Random();

            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                var value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }

        public Card DrawCard(List<Card> deck)
        {
            if (deck.Count > 0)
            {
                Card card = deck[0]; // Wybierz pierwszą kartę na liście (góra talii)
                deck.RemoveAt(0); // Usuń wybraną kartę z listy
                return card;
            }
            else
            {
                throw new InvalidOperationException("Talia kart jest pusta.");
            }
        }
    }
}
