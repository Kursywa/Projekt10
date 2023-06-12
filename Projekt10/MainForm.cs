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

namespace Projekt10
{
    public partial class MainForm : Form
    {
        //private WaveOutEvent outputDevice;
        //private AudioFileReader audioFile;
        //private Thread musicThread;
        private bool warwin;
        private bool blackjackwin;
        private bool DrawButtonClicked, StayButtonClicked;
        private bool endgame = false;
        string[] Suits = { "hearts", "spades", "diamonds", "clubs" };
        List<Card> PlayerDeck, OpponentDeck, MainDeck, PlayerSide, OpponentSide;
        int Opponentscore, Playerscore, playerwins, opponentwins;

        public MainForm()
        {
            InitializeComponent();
            /*outputDevice = new WaveOutEvent();
            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Music\\Soundtrack.mp3"); ;
            audioFile = new AudioFileReader(filePath);*/
            blackjackwin = false;
            DrawButtonClicked = false;
            StayButtonClicked = false;
            Opponentscore = 0;
            Playerscore = 0;
        }
        private void PlayWar() //implementujemy wojne tutaj
        {                      //ace>king>queen>jack>10>9>8>7>6>5>4>3>2
            StayBtn.Hide();
            warReset();
            Deck deck = new Deck();
            MainDeck = new List<Card>();
            OpponentSide = new List<Card>();
            PlayerSide = new List<Card>();
            deck.MakeDefaultDeck();
            MainDeck = deck.GetDeck();
            deck.Shuffle(MainDeck);//tosujemy karty
            OpponentDeck = new List<Card>(26);
            PlayerDeck = new List<Card>(26);


            for (int i = 0; i < 26; i++) //rozdzielenie kart miedzy graczami
            {
                OpponentDeck.Add(deck.DrawCard(MainDeck));
                PlayerDeck.Add(deck.DrawCard(MainDeck));
            }

            while (!endgame)            //jezeli przeniesiemy tego while do drawbtn_click to nie zawiesi sie, ale wykona tylko jeden raz
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
            }
        }

        private void WarComparison(Card playercard, Card opponentcard)
        {
            if (playercard.GetValue() == opponentcard.GetValue())
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
            }

            if (PlayerDeck.Count == 52)/*komunikat wygranej i break*/
            {
                endgame = true;
                Verdict.Text = "Wygrana";
            }
            if (PlayerDeck.Count == 0)/*komunikat przegranej i break*/
            {
                endgame = true;
                Verdict.Text = "Przegrana";
            }
        }

        private void PlayBlackjack() //implementujemy oczko tutaj
        {                            //highest card value is 11 and give it place for 6 cards max per player
            bool Opponentstay = false;
            bool Playerstay = false;
            playerwins = 0;
            opponentwins = 0; //po co to?żeby użytkownik też mógł przegrać
            StayBtn.Show();
            jackReset();
            Deck deck = new Deck();
            MainDeck = new List<Card>();
            OpponentSide = new List<Card>();
            PlayerSide = new List<Card>();
            deck.MakeDefaultDeck();
            MainDeck = deck.GetDeck();
            deck.Shuffle(MainDeck);//tosujemy karty

            for (int i = 0; i < 56; i++)//we need to change values for the game
            {
                if (MainDeck[i].GetValue() == 11) MainDeck[i].SetValue(2);
                if (MainDeck[i].GetValue() == 12) MainDeck[i].SetValue(3);
                if (MainDeck[i].GetValue() == 13) MainDeck[i].SetValue(4);
                if (MainDeck[i].GetValue() == 14) MainDeck[i].SetValue(11);
            }

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

            while (true)
            {
                //opponentlabel should be ? + the rest of the upfaced cards
                //opponentlabel should be backfaced card value + the rest of the upfaced cards

                if (DrawButtonClicked)
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
                }

                if (StayButtonClicked) Playerstay = true;

                if (Playerstay && Opponentstay) BlackJackComparison();

                if (playerwins == 2)/*wygrywasz i break*/;
                if (opponentwins == 2)/*przegrywasz i break*/;
            }
        }

        private void BlackJackComparison()
        {
            if ((Opponentscore <= 21 && Playerscore > 21) || (Opponentscore > 21 && Playerscore > 21 && Opponentscore < Playerscore) || (Opponentscore <= 21 && Playerscore <= 21 && Opponentscore > Playerscore))
            {
                opponentwins++;
            }

            if ((Opponentscore > 21 && Playerscore <= 21) || (Opponentscore > 21 && Playerscore > 21 && Opponentscore > Playerscore) || (Opponentscore <= 21 && Playerscore <= 21 && Opponentscore < Playerscore))
            {
                playerwins++;
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //po klinkięciu "start" egzekwowane są metody zależne od opcji:
            //blackjack albo war game
            groupBox1.Hide();
            testlabel.Text = "start nacisniety";
            DrawBtn.Show();
            StopBtn.Show();
            testlabel.Text = "start nacisniety";
            //BackgroundpictureBox.Show();
            //BackgroundpictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("background.jpg");
            if (WarRadioBtn.Checked) PlayWar();
            if (BlackjackRadioBtn.Checked) PlayBlackjack();
        }

        private void StopBtn_Click(object sender, EventArgs e)//stop the game
        {
            DrawBtn.Hide();//mf cant do a thing because we hide the action buttons
            StayBtn.Hide();
            StopBtn.Hide();
            groupBox1.Show();
            ResumeBtn.Show();
        }
        private void DrawBtn_Click(object sender, EventArgs e)
        {
            //play the drawsound I guess
            DrawButtonClicked = true;
        }

        private void StayBtn_Click(object sender, EventArgs e)
        {
            //let the Ai have it's turn to draw or stay or just draw
            StayButtonClicked = true;
        }

        private void jackReset()//The blackjack reset
        {
            //Show blackJack UI
        }

        private void warReset()//The war reset
        {
            //Show war UI
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
        
    }
}
