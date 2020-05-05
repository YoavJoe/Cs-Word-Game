using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WordGame_YoavShalev
{
    public partial class WordGame : Form
    {
        static Random _random = new Random();
        int OrigTime = 60;
        int currentPlayer = 1;
        string[] word = new string[10];
        string player1Words = "";
        string player2Words = "";
        public WordGame()
        {
            InitializeComponent();
            lblPlayer.Text = "Current Player is " + currentPlayer;

        }

        private void StartTurn()
        {

            GetRandomLetter();
            for (int i = 0; i < word.Length; i++)
            {
                lblLetters.Text += word[i] + " ,";
            }

            timer1.Start();
        }

        public string[] GetRandomLetter()
        {

            for (int i = 0; i < 10; i++)
            {
                int num = _random.Next(0, 26);
                word[i] = ((char)('a' + num)).ToString();
            }
            return word;
        }

        private void Reset()
        {
            OrigTime = 60;
            lblLetters.Text = "";
            lstWords.Items.Clear();
            txtNewWord.Text = "";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            OrigTime--;
            if (OrigTime == 0)
            {
                TurnOver();
            }
            else
            {
                lblTimer.Text = OrigTime / 60 + ":" + ((OrigTime % 60) >= 10 ? (OrigTime % 60).ToString() : "0" + OrigTime % 60);
            }

        }


        private void TurnOver()
        {
            timer1.Stop();

            if (currentPlayer == 1)
            {
                btnStart.Enabled = true;
                Reset();
                currentPlayer = 2;
                lblPlayer.Text = "Current Player is " + currentPlayer;
            }
            else
            {
                ShowPLayersWords();
            }

        }


        private void ShowPLayersWords()
        {
            string[] p1Words = player1Words.Split('|');
            string[] p2Words = player2Words.Split('|');

            for (int i = 0; i < p1Words.Length; i++)
            {
                lstP1.Items.Add(p1Words[i]);
            }

            for (int i = 0; i < p2Words.Length; i++)
            {
                lstp2.Items.Add(p2Words[i]);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            StartTurn();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (currentPlayer == 1)
            {
                player1Words += txtNewWord.Text + "|";
            }
            else
            {
                player2Words += txtNewWord.Text + "|";
            }

            lstWords.Items.Add(txtNewWord.Text);
        }

        private void btnP1Delete_Click(object sender, EventArgs e)
        {
            lstP1.Items.Remove(lstP1.SelectedItem);
        }
        private void btnp2Delete_Click(object sender, EventArgs e)
        {
            lstp2.Items.Remove(lstp2.SelectedItem);
        }
        private void btnCheckWin_Click(object sender, EventArgs e)
        {
            if (lstP1.Items.Count == lstp2.Items.Count)
            {
                MessageBox.Show("Player 1 and player 2 are equal");
            }
            else if (lstP1.Items.Count > lstp2.Items.Count)
            {
                MessageBox.Show("Player 1 is the winner");
            }
            else
            {
                MessageBox.Show("Player 2 is the winner");
            }
        }

        private void Restartbt_Click(object sender, EventArgs e)
        {
            Reset();
            StartTurn();
        }

        private void lblPlayer_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
