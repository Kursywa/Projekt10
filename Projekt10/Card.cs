using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projekt10
{
    internal class Card
    {
        private string Suit;
        private int Value;
        private string FaceCard;

        public Card(string s, int v)
        {
            Suit = s;
            Value = v;

            switch (v)
            {
                case 11:
                    FaceCard = s + "jack";
                    break;
                case 12:
                    FaceCard = s + "queen";
                    break;
                case 13:
                    FaceCard = s + "king";
                    break;
                case 14:
                    FaceCard = s + "ace";
                    break;
                default:
                    FaceCard = s + v.ToString();
                    break;
            }
        }
   
        public void SetValue(int v)
        {
            Value = v;
        }

        public int GetValue()
        {
            return Value;
        }

        public void SetSuit(string s)
        {
            Suit = s;
        }

        public string GetSuit()
        {
            return Suit;
        }

        public string GetFaceCard()
        {
            return FaceCard;
        }

        public void SetFaceCard(string fc)
        {
            FaceCard = fc;
        }
    }
}
