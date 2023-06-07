using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt10
{
    public partial class MainForm : Form
    {
        string[] Suits = { "hearts", "spades", "diamonds", "clubs" };
        int min, max;
        public MainForm()
        {
            InitializeComponent();
            Random random = new Random();
            min = 2;
            max = 14;
        }
        private void PlayWar() //implementujemy wojne tutaj
        {                      //ace>king>queen>jack>10>9>8>7>6>5>4>3>2
            Deck deck = new Deck();
            deck.MakeDefaultDeck();
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
    }
}
