using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        private string wordToGuess = "computer";
        StringBuilder word = new StringBuilder("c??????r");
        public Form1()
        {
            InitializeComponent();
            InitializeGuessWord();
        }
        private void InitializeGuessWord()
        {
            lblWordToGuess.Text = word.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userGuess = txtGuess.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(userGuess))
            {
                MessageBox.Show("Please enter a word.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userGuess == wordToGuess)
            {
                lblWordToGuess.Text = wordToGuess;
                MessageBox.Show("Correct guess!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (!listBox1.Items.Contains(userGuess))
                {
                    listBox1.Items.Add(userGuess);
                }
                MessageBox.Show("Wrong guess! Try again.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtGuess.Clear();
            txtGuess.Focus();
        }
    }
}
