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
        private static WaveOutEvent outputDevice;
        private static AudioFileReader audioFile;
        string[] Suits = { "hearts", "spades", "diamonds", "clubs" };
        List<Card> PlayerHand, OpponentHand, MainDeck;
        int min, max;

        public MainForm()
        {
            InitializeComponent();
            BackgroundMusic();
            Random random = new Random();
            min = 2;
            max = 14;
        }
        private void PlayWar() //implementujemy wojne tutaj
        {                      //ace>king>queen>jack>10>9>8>7>6>5>4>3>2
            Deck deck = new Deck();
            MainDeck = new List<Card>();
            MainDeck = deck.GetDeck();
            deck.MakeDefaultDeck();
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
            //po klinkięciu "start" egzekwowane są metody zależne od opcji:
            //blackjack albo war game
            if (WarRadioBtn.Checked)
            {
                DrawBtn.Hide();
                StopBtn.Hide();
                PlayWar();
            }
            else if (BlackjackRadioBtn.Checked)
            {

                DrawBtn.Show();
                StopBtn.Show();
                PlayBlackjack();
            }
        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {

        }

        public void BackgroundMusic()
        {
            string filePath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "Music\\Soundtrack.mp3");

            // Inicjalizacja odtwarzacza
            outputDevice = new WaveOutEvent();
            audioFile = new AudioFileReader(filePath);

            // Rozpoczęcie odtwarzania muzyki
            outputDevice.Init(audioFile);
            outputDevice.Play();

            // Pozostała część kodu Twojego programu

            // Przykładowa pętla główna programu
            while (true)
            {
                // Tutaj umieść kod Twojej aplikacji

                // Sprawdzenie, czy plik audio został zakończony
                if (audioFile.Position >= audioFile.Length)
                {
                    audioFile.Position = 0; // Przewijanie na początek pliku
                    outputDevice.Play(); // Ponowne odtwarzanie
                }

                // Przykład użycia opóźnienia, aby nie obciążać procesora
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
