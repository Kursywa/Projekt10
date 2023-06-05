using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projekt10
{
    internal class Card
    {

        string Suit = ""; //figura karty
        int Value = 0; // wartosc karty
        string FaceCard = ""; //widoczna figura
        
        public Card() //konstruktor bezparametrowy
        {
            Suit = "";
            Value = 0;
            FaceCard = "";
        }

        public Card(string s, int v) //konstruktor z konkretnymi wartościami
        {
            Suit = s;
            Value = v;
            switch (Value) //przypisanie figury w zależności od wartości
            {
                case 11:
                    FaceCard = "Jack";
                    break;
                case 12:
                    FaceCard = "Queen";
                    break;
                case 13:
                    FaceCard = "King";
                    break;
                case 14:
                    FaceCard = "Ace";
                    break;
                default:
                    FaceCard = Value.ToString();
                    break;
            }
        }
        public void ChangeValue(int v) //metoda do zmiany wartości karty
                    {
                        Value = v;
                    }
    }
}
