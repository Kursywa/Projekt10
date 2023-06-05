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
        List<Card> CurrentDeck;
        int SizeOfDeck;

        public Deck() //konstruktor tworzący standardową talię 52 kart
        {
            SizeOfDeck = 52;
            CurrentDeck = new List<Card>(SizeOfDeck);
        }

        public void MakeDefaultDeck()
        {
            Card newCard;
            for(int i =0; i < 52; i++)
            {
                if (i < 14)
                {
                    newCard = new Card("<3", i + 1); //serca to <3
                }
                else if (i < 27)
                {
                    newCard = new Card(">3", i + 1); // pik to >3
                }
                else if(i < 40)
                {
                    newCard = new Card("<>", i + 1); //karo to <>
                }
                else
                {
                    newCard = new Card("%", i + 1); // trefl to %
                }

                    CurrentDeck.Add(newCard);  //tak stworzona talia bedzie miala wszytskie figury
                                               // z odpowiednimi kolorami
            }
        }


    }
}
