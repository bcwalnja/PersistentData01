using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windforms_Project_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool SwitchPlayer;
        
        private void A1_Click(object sender, EventArgs e)
        {
            ResetGame.Enabled = false;

            Button BTN = sender as Button;

            PlayerOne.Text = "";

            PlayerTwo.Text = "";

            if (SwitchPlayer == true)
            { PlayerOne.Text = "O"; }

            else
            { PlayerTwo.Text = "X"; }

            if (SwitchPlayer == true)
            { BTN.Text = "X"; }

            else
            { BTN.Text = "O"; }

            BTN.Enabled = false;

            CheckForWin();
            CheckforDraw();

            SwitchPlayer = !SwitchPlayer;

        }

        private void CheckForWin()
        {
            //Horizontal Check 
            CheckHorizontalWinFor("O");
            CheckHorizontalWinFor("X");

            //Vertical Check 
            CheckVerticalWinFor("O");
            CheckVerticalWinFor("X");

            //Diagonal Check 
            CheckDiagonalWinFor("O");
            CheckDiagonalWinFor("X");
        }

        private void CheckDiagonalWinFor(string player)
        {
            if ((A1.Text == player && B2.Text == player && C3.Text == player) ||
                (A3.Text == player && B2.Text == player && C1.Text == player))
            { DisplayWinMessage(player); }
        }

        private void CheckVerticalWinFor(string player)
        {
            if ((A1.Text == player && B1.Text == player && C1.Text == player) ||
                (A2.Text == player && B2.Text == player && C2.Text == player) ||
                (A3.Text == player && B3.Text == player && C3.Text == player))
            { DisplayWinMessage(player); }
        }

        private void CheckHorizontalWinFor(string player)
        {
            if ((A1.Text == player && A2.Text == player && A3.Text == player) ||
                (C1.Text == player && C2.Text == player && C3.Text == player) ||
                (B1.Text == player && B2.Text == player && B3.Text == player))
            { DisplayWinMessage(player); }
        }

        private void CheckforDraw()
        {
            bool gameShouldReset = true;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control.Text == "X" || control.Text == "O")
                {  
                    continue;
                }

                else
                {
                    gameShouldReset = false;
                    break;
                }
            }

            if(gameShouldReset)
            {
                ResetGame.Enabled = true;
            }
        }

        private void DisplayWinMessage(string winner)
        {
            MessageBox.Show($"{winner} Wins!", "Congratulations");
            SetButtonsEnabled(false);
            ResetGame.Enabled = true;
        }

        void SetButtonsEnabled(bool enabled)
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                control.Enabled = enabled;
            }
        }

        void ResetText()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                control.Text = "";
            }
        }

        private void ResetGame_Click(object sender, EventArgs e)
        {
            ResetText();
            SetButtonsEnabled(true);
        }
    }
}
