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

namespace Projekt10
{
    public partial class MainForm : Form
    {
        //private WaveOutEvent outputDevice;
        //private AudioFileReader audioFile;
        //private Thread musicThread;
        string[] Suits = { "hearts", "spades", "diamonds", "clubs" };
        List<Card> PlayerHand, OpponentHand, MainDeck;
        int min, max;

        public MainForm()
        {
            InitializeComponent();
            /*outputDevice = new WaveOutEvent();
            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Music\\Soundtrack.mp3"); ;
            audioFile = new AudioFileReader(filePath);*/
            Random random = new Random();
            min = 2;
            max = 14;
        }
        private void PlayWar() //implementujemy wojne tutaj
        {                      //ace>king>queen>jack>10>9>8>7>6>5>4>3>2
            Deck deck = new Deck();
            MainDeck = new List<Card>();
            deck.MakeDefaultDeck();
            MainDeck = deck.GetDeck();
            deck.Shuffle(MainDeck);//tosujemy karty
            OpponentHand = new List<Card>(26);
            PlayerHand = new List<Card>(26);
            for (int i = 0; i < 26; i++)
            {
                OpponentHand.Add(deck.DrawCard(MainDeck));
                PlayerHand.Add(deck.DrawCard(MainDeck));
            }
        }


        private void PlayBlackjack() //implementujemy oczko tutaj
        {
            Deck deck = new Deck();
            deck.MakeDefaultDeck();
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            /*musicThread = new Thread(PlayMusic);
            musicThread.IsBackground = true;
            musicThread.Start();*/
            //po klinkięciu "start" egzekwowane są metody zależne od opcji:
            //blackjack albo war game
            if (WarRadioBtn.Checked)
            {
                DrawBtn.Show();
                StopBtn.Show();
                PlayWar();
            }

            if (BlackjackRadioBtn.Checked)
            {

                DrawBtn.Show();
                StopBtn.Show();
                PlayBlackjack();
            }
        }

        /*private void PlayMusic()
        {
            outputDevice.Init(audioFile);
            outputDevice.Play();

            while (true)
            {
                // Tutaj umieść kod związanego z pętlą gry

                // Przykład opóźnienia, aby nie obciążać procesora
                Thread.Sleep(100);
            }
        }*/

        /*protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Zatrzymaj odtwarzanie muzyki i zakończ wątek
            outputDevice.Stop();
            musicThread.Join();
        }*/

        private void DrawBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
