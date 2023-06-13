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
        public MainForm()
        {
            InitializeComponent();
            /*outputDevice = new WaveOutEvent();
            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Music\\Soundtrack.mp3"); ;
            audioFile = new AudioFileReader(filePath);*/
            DrawButtonClicked = false;
            StayButtonClicked = false;
            Opponentscore = 0;
            Playerscore = 0;
        }
        private void PlayWar() //implementujemy wojne tutaj
        {                      //ace>king>queen>jack>10>9>8>7>6>5>4>3>2
            StayBtn.Hide();
            Deck deck = new Deck();
            MainDeck = new List<Card>();
            deck.MakeDefaultDeck();
            MainDeck = deck.GetDeck();
            deck.Shuffle(MainDeck);//tosujemy karty
            OpponentDeck = new List<Card>();
            PlayerDeck = new List<Card>();
            OpponentHand = new List<Card>();
            PlayerHand = new List<Card>();


            for (int i = 0; i < 26; i++) //rozdzielenie kart miedzy graczami
            {
                OpponentDeck.Add(Deck.DrawCard(MainDeck));
                PlayerDeck.Add(Deck.DrawCard(MainDeck));
            }
            //uaktualnienie labelek decków graczy
            OpponentNumberOfCards.Text = OpponentDeck.Count.ToString();
            PlayerNumberOfCards.Text = PlayerDeck.Count.ToString();

            /* while (!endgame)            //jezeli przeniesiemy tego while do drawbtn_click to nie zawiesi sie, ale wykona tylko jeden raz
             {
                 if (DrawButtonClicked)
                 {
                     DrawButtonClicked = false;
                     if (PlayerDeck.Count > 0)//danie graczowi karty
                     {
                         Card drawnCard = PlayerDeck[0];
                         PlayerDeck.RemoveAt(0);
                         PlayerSide.Add(drawnCard);

                         // Instrukcje dotyczące wyświetlania karty gracza
                         Player_label.Text = drawnCard.GetSuit().ToString() + drawnCard.GetValue().ToString();
                     }

                     if (OpponentDeck.Count > 0)//danie przeciwnikowi karty
                     {
                         Card opponentCard = OpponentDeck[0];
                         OpponentDeck.RemoveAt(0);
                         OpponentSide.Add(opponentCard);

                         // Instrukcje dotyczące wyświetlania karty przeciwnika
                         Opponent_label.Text = opponentCard.GetSuit().ToString() + opponentCard.GetValue().ToString();
                     }

                     SetCard(PlayerSide, PlayerCard);
                     SetCard(OpponentSide, OpponentCard);
                 }

                 if (PlayerSide.Count > 0 && OpponentSide.Count > 0)
                 {
                     WarComparison(PlayerSide[PlayerSide.Count - 1], OpponentSide[OpponentSide.Count - 1]);
                 }
             }*/
        }

        private void WarComparison(Card playercard, Card opponentcard)
        {

            /* if (playercard.GetValue() == opponentcard.GetValue())
             {
                 PlayerSide.Add(PlayerDeck[0]);
                 PlayerDeck.RemoveAt(0);
                 OpponentSide.Add(OpponentDeck[0]);
                 OpponentDeck.RemoveAt(0);
             }
             else if (playercard.GetValue() > opponentcard.GetValue())
             {
                 PlayerDeck.AddRange(PlayerSide);
             }
             else
             {
                 OpponentDeck.AddRange(OpponentSide);
             }*/

            if (PlayerDeck.Count == 52)/*komunikat wygranej i break*/
            {
                WinOrLoseWindow(WinText);
            }
            else if (PlayerDeck.Count == 0)/*komunikat przegranej i break*/
            {
                WinOrLoseWindow(WinText);
            }
        }

        private void PlayBlackjack() //implementujemy oczko tutaj
        {                            //highest card value is 11 and give it place for 6 cards max per player
            bool Opponentstay = false;
            bool Playerstay = false;
            StayBtn.Show();
            Deck deck = new Deck();
            MainDeck = new List<Card>();
            /*OpponentSide = new List<Card>();
            PlayerSide = new List<Card>();*/
            deck.MakeDefaultDeck();
            MainDeck = deck.GetDeck();
            deck.Shuffle(MainDeck);//tosujemy karty
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
            while (true)
            {
                //opponentlabel should be ? + the rest of the upfaced cards
                //opponentlabel should be backfaced card value + the rest of the upfaced cards

                /*if (DrawButtonClicked)
                {
                    DrawButtonClicked = false;
                    PlayerSide.Add(MainDeck[0]);
                    MainDeck.RemoveAt(0);
                    Playerscore += PlayerSide[PlayerSide.Count - 1].GetValue();

                    if (Opponentscore < 21)
                    {
                        OpponentSide.Add(MainDeck[0]);
                        MainDeck.RemoveAt(0);
                        Opponentscore += OpponentSide[OpponentSide.Count - 1].GetValue();
                    }
                    else Opponentstay = true;
                }*/

                if (StayButtonClicked) Playerstay = true;

                if (Playerstay && Opponentstay) BlackJackComparison();

            }
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
            if (WarRadioBtn.Checked) PlayWar();
            if (BlackjackRadioBtn.Checked) PlayBlackjack();
        }

        private void StopBtn_Click(object sender, EventArgs e)//stop the game
        {
            DrawBtn.Hide();//mf cant do a thing because we hide the action buttons
            StayBtn.Hide();
            StopBtn.Hide();
            //groupBox1.Show();
            ResumeBtn.Show();
        }
        private void DrawBtn_Click(object sender, EventArgs e) //przy nacisnieciu przycisku draw
        {
            OpponentHand.Add(Deck.DrawCard(OpponentDeck));//dobierz z decku ooponenta
            PlayerHand.Add(Deck.DrawCard(PlayerDeck)); //dobierz z decku gracza
            //zliczenie wyniku
            Opponentscore = OpponentHand.Sum(obj => obj.GetValue());
            Playerscore = PlayerHand.Sum(obj => obj.GetValue());
            //aktualizacja labelek
            SetCard(OpponentHand, OpponentCard); //zaktualizuj karte
            SetCard(PlayerHand, PlayerCard); //karta
            OpponentNumberOfCards.Text = OpponentDeck.Count.ToString(); //karty w decku
            PlayerNumberOfCards.Text = PlayerDeck.Count.ToString(); //karty w decku
            Opponent_label.Text = "Score: " + Opponentscore.ToString(); //wynik aktualny
            Player_label.Text = "Score: " + Playerscore.ToString(); //wynik aktualny
            //DrawButtonClicked = true; //nie wiem po co to
        }

        private void StayBtn_Click(object sender, EventArgs e)
        {
            //let the Ai have it's turn to draw or stay or just draw
            StayButtonClicked = true;
        }
        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            DrawBtn.Show();
            StopBtn.Show();

            if (WarRadioBtn.Checked) PlayWar();
            else if (BlackjackRadioBtn.Checked) PlayBlackjack();

            if (WarRadioBtn.Checked) StayBtn.Hide();
            else if (BlackjackRadioBtn.Checked) StayBtn.Show();
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

        public void WinOrLoseWindow(string text)
        {
            DialogResult result = MessageBox.Show(text);
            if (result == DialogResult.OK)
            {
                Application.Restart();
            }
        }
    }
}
