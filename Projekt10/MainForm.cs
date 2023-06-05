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
        public MainForm()
        {
            InitializeComponent();
        }
        private void PlayWar() //implementujemy wojne tutaj
        {

        }


        private void PlayBlackjack() //implementujemy oczko tutaj
        {

        }
        private void StartBtn_Click(object sender, EventArgs e) 
        {
            //po klinkięciu "start" egzekwowane są metody zależne od opcji:
            //blackjack albo war game
            if (WarRadioBtn.Checked)
            {
                PlayWar();
            }
            else if(BlackjackRadioBtn.Checked)
            {
                PlayBlackjack();
            }
        }
    }
}
