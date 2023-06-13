using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using System.IO;
using Projekt10.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Threading;

namespace Projekt10
{
    public partial class MainForm : Form
    {
        //private WaveOutEvent outputDevice;
        //private AudioFileReader audioFile;
        //private Thread musicThread;
        private bool DrawButtonClicked, StayButtonClicked;
        private bool endgame = false;
        string[] Suits = { "hearts", "spades", "diamonds", "clubs" };
        int Opponentscore, Playerscore;
        string LoseText = "You lost!";
        string WinText = "You win!";
        List<Card> OpponentDeck = new List<Card>();
        List<Card> OpponentHand = new List<Card>();
        List<Card> PlayerDeck = new List<Card>();
        List<Card> PlayerHand = new List<Card>();
        List<Card> MainDeck = new List<Card>();
        bool OpponentPass = false;
        bool PlayerPass = false;
        public MainForm()
        {
            InitializeComponent();
            DrawButtonClicked = false;
            StayButtonClicked = false;
            Opponentscore = 0;
            Playerscore = 0;
        }
        private void InitializeWar() //implementujemy wojne tutaj
        {                      //ace>king>queen>jack>10>9>8>7>6>5>4>3>2
            PassBtn.Hide();
            Deck deck = new Deck();
            MainDeck = new List<Card>();
            deck.MakeDefaultDeck();
            MainDeck = deck.GetDeck();
            deck.Shuffle(MainDeck);//tosujemy karty



            for (int i = 0; i < 26; i++) //rozdzielenie kart miedzy graczami
            {
                OpponentDeck.Add(Deck.DrawCard(MainDeck));
                PlayerDeck.Add(Deck.DrawCard(MainDeck));
            }
            //uaktualnienie labelek decków graczy
            OpponentNumberOfCards.Text = OpponentDeck.Count.ToString();
            PlayerNumberOfCards.Text = PlayerDeck.Count.ToString();

            Opponent_label.Hide();
            Player_label.Hide();
        }

        private void WarComparison(Card playercard, Card opponentcard)
        {
            if (playercard.GetValue() == opponentcard.GetValue())
            {
                PlayerHand.Add(PlayerDeck[0]);
                PlayerDeck.RemoveAt(0);
                OpponentHand.Add(OpponentDeck[0]);
                OpponentDeck.RemoveAt(0);
            }
            else if (playercard.GetValue() > opponentcard.GetValue())
            {
                PlayerDeck.AddRange(PlayerHand);
            }
            else
            {
                OpponentDeck.AddRange(OpponentHand);
            }

            if (PlayerDeck.Count == 52)/*komunikat wygranej i break*/
            {
                WinOrLoseWindow(WinText);
            }
            else if (PlayerDeck.Count == 0)/*komunikat przegranej i break*/
            {
                WinOrLoseWindow(WinText);
            }
        }

        private void InitilizeBlackjack() //implementujemy oczko tutaj
        {                            //highest card value is 11 and give it place for 6 cards max per player
            Deck deck = new Deck();
            MainDeck = new List<Card>();
            deck.MakeDefaultDeck();
            MainDeck = deck.GetDeck();
            deck.Shuffle(MainDeck);//tosujemy karty
            PassBtn.Show();
            //trzeba zrobić foreachem
            foreach (var Deck in MainDeck)
            {
                switch (Deck.GetValue())
                {
                    case 11:
                        Deck.SetValue(2);
                        break;
                    case 12:
                        Deck.SetValue(3);
                        break;
                    case 13:
                        Deck.SetValue(4);
                        break;
                    case 14:
                        Deck.SetValue(11);
                        break;
                }
            }
        }
        private void PlayBlackjack() 
        {
            //metoda na dobieranie do ręki
            //dobierz z decku ooponenta

            PlayerHand.Add(Deck.DrawCard(MainDeck)); //dobierz z decku gracza
            Playerscore = PlayerHand.Sum(obj => obj.GetValue());
            //zliczenie wyniku (przenieść do odzielnej funkcji  zależności od gry
            if (Playerscore > Opponentscore && Opponentscore < 18)
            {
                OpponentHand.Add(Deck.DrawCard(MainDeck));
                Opponentscore = OpponentHand.Sum(obj => obj.GetValue());
            }
            else
            {
                OpponentPass = true;
            }

            ActualizeLabels();
            /*for (int i = 0; i < 56; i++)//we need to change values for the game
            {
                if (MainDeck[i].GetValue() == 11) MainDeck[i].SetValue(2);
                if (MainDeck[i].GetValue() == 12) MainDeck[i].SetValue(3);
                if (MainDeck[i].GetValue() == 13) MainDeck[i].SetValue(4);
                if (MainDeck[i].GetValue() == 14) MainDeck[i].SetValue(11);

            }*/
            //tu powinna być mertoda przleiczająca ręke przeciwnika i gracza
            /*
                        PlayerSide.Add(MainDeck[0]);//backfaced
                        MainDeck.RemoveAt(0);
                        Playerscore += PlayerSide[PlayerSide.Count - 1].GetValue();

                        OpponentSide.Add(MainDeck[0]);//backfaced
                        MainDeck.RemoveAt(0);
                        Opponentscore += OpponentSide[OpponentSide.Count - 1].GetValue();

                        PlayerSide.Add(MainDeck[0]);//upfaced
                        MainDeck.RemoveAt(0);
                        Playerscore += PlayerSide[PlayerSide.Count - 1].GetValue();

                        OpponentSide.Add(MainDeck[0]);//upfaced
                        MainDeck.RemoveAt(0);
                        Opponentscore += OpponentSide[OpponentSide.Count - 1].GetValue();
            */
        

                if (PlayerPass && OpponentPass) BlackJackComparison();

        }
        

        private void BlackJackComparison()
        {
            if ((Opponentscore <= 21 && Playerscore > 21) || (Opponentscore > 21 && Playerscore > 21 && Opponentscore < Playerscore) || (Opponentscore <= 21 && Playerscore <= 21 && Opponentscore > Playerscore))
            {
                WinOrLoseWindow(WinText);
            }

            if ((Opponentscore > 21 && Playerscore <= 21) || (Opponentscore > 21 && Playerscore > 21 && Opponentscore > Playerscore) || (Opponentscore <= 21 && Playerscore <= 21 && Opponentscore < Playerscore))
            {
                WinOrLoseWindow(LoseText);
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //po klinkięciu "start" egzekwowane są metody zależne od opcji:
            //blackjack albo war game

            //groupBox1.Hide();
            DrawBtn.Show();
            StopBtn.Show();
            if (BlackjackRadioBtn.Checked) InitilizeBlackjack();
            if (WarRadioBtn.Checked) InitializeWar();
        }

        private void DrawBtn_Click(object sender, EventArgs e) //przy nacisnieciu przycisku draw
        {
            if (WarRadioBtn.Checked)//jeżeli gramy w wojne to pobieramy karte jak na wojnie
            {
                OpponentHand.Add(Deck.DrawCard(OpponentDeck));//dobierz z decku ooponenta
                PlayerHand.Add(Deck.DrawCard(PlayerDeck)); //dobierz z decku gracza
                                                           //zliczenie wyniku (przenieść do odzielnej funkcji  zależności od gry
                                                           //aktualizacja labelek (przenieść ją do oddzielnej funkcji dla wojny lub oczka)
                SetCard(OpponentHand, OpponentCard); //zaktualizuj karte
                SetCard(PlayerHand, PlayerCard); //karta
                OpponentNumberOfCards.Text = OpponentDeck.Count.ToString(); //karty w decku
                PlayerNumberOfCards.Text = PlayerDeck.Count.ToString(); //karty w decku
                Opponent_label.Text = "Score: " + Opponentscore.ToString(); //wynik aktualny
                Player_label.Text = "Score: " + Playerscore.ToString(); //wynik aktualny

                if (PlayerDeck.Count > 0)//danie graczowi karty
                {
                    Card drawnCard = PlayerDeck[0];
                    PlayerDeck.RemoveAt(0);
                    PlayerHand.Add(drawnCard);
                    // Instrukcje dotyczące wyświetlania karty gracza
                    Player_label.Text = drawnCard.GetSuit().ToString() + drawnCard.GetValue().ToString();
                }

                if (OpponentDeck.Count > 0)//danie przeciwnikowi karty
                {
                    Card opponentCard = OpponentDeck[0];
                    OpponentDeck.RemoveAt(0);
                    OpponentHand.Add(opponentCard);
                    // Instrukcje dotyczące wyświetlania karty przeciwnika
                    Opponent_label.Text = opponentCard.GetSuit().ToString() + opponentCard.GetValue().ToString();
                }

                SetCard(PlayerHand, PlayerCard);
                SetCard(OpponentHand, OpponentCard);


                if (PlayerHand.Count >= 0 && OpponentHand.Count >= 0)
                {
                    WarComparison(PlayerHand[PlayerHand.Count - 1], OpponentHand[OpponentHand.Count - 1]);
                }
            }
            if(BlackjackRadioBtn.Checked) PlayBlackjack();
        }

        private void StayBtn_Click(object sender, EventArgs e)
        {
            PlayerPass = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void AppendCard()
        {

        }
        private void SetCard(List<Card> card, System.Windows.Forms.PictureBox picturebox)
        { //metoda ustawiająca picturebox na odpowiednie zdjecie z repozytorium
            //input (OpponentSide lub PlayerSide, OpponentCard lub PlayerCard) kolejno
            Card analyzedCard = card[card.Count - 1]; //przypisanie pierwszej karty z reki
            string FaceCard = analyzedCard.GetFaceCard();
            //switch case bhy przydzielic karcie odpowiedni obrazek
            var ImageName = analyzedCard.GetFaceCard().ToString();
            picturebox.Image = (Image)Properties.Resources.ResourceManager.GetObject(ImageName);
        }

        private void WinOrLoseWindow(string text)
        {
            DialogResult result = MessageBox.Show(text);
            if (result == DialogResult.OK)
            {
                Application.Restart();
            }
        }
        private void ActualizeLabels()
        {
            SetCard(OpponentHand, OpponentCard); //zaktualizuj karte
            SetCard(PlayerHand, PlayerCard); //karta
            OpponentNumberOfCards.Text = OpponentDeck.Count.ToString(); //karty w decku
            PlayerNumberOfCards.Text = PlayerDeck.Count.ToString(); //karty w decku
            Opponent_label.Text = "Score: " + Opponentscore.ToString(); //wynik aktualny
            Player_label.Text = "Score: " + Playerscore.ToString(); //wynik aktualny
        }
    }
}
