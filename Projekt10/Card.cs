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
        string Suit = "";//figura karty
        int Value = 0; // wartosc karty
        string FaceCard = ""; //widoczna wartość

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
                    FaceCard = Suit + "jack";
                    break;
                case 12:
                    FaceCard = Suit + "queen";
                    break;
                case 13:
                    FaceCard = Suit + "king";
                    break;
                case 14:
                    FaceCard = Suit + "ace";
                    break;
                default:
                    FaceCard = Suit + Value.ToString();
                    break;
            }
        }
        public void SetValue(int v) //metoda do zmiany wartości karty
        {
            Value = v;
        }

        public int GetValue() //metoda do zmiany wartości karty
        {
            return Value;
        }

        public void SetSuit(string s) //metoda do zmiany wartości karty
        {
            Suit = s;
        }

        public string GetSuit() //metoda do zmiany wartości karty
        {
            return Suit;
        }
    }
}
