using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms_Project_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool IsSecondPlayer;
        
        private void label_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;
            if (IsSecondPlayer == false)
                clickedLabel.Text = "O";
            
            else
                PickSquare();
            IsSecondPlayer = !IsSecondPlayer;
            CheckForWin();
        }
        private void PickSquare()
        {
            Random random = new Random();

            List<Label> labels = new List<Label>()
            {L1,L2,L3,L4,L5,L6,L7,L8,L9};

            int index = random.Next(labels.Count);
           
            if (!string.IsNullOrWhiteSpace(L1.Text) &&
                !string.IsNullOrWhiteSpace(L2.Text) &&
                !string.IsNullOrWhiteSpace(L3.Text) &&
                !string.IsNullOrWhiteSpace(L4.Text) &&
                !string.IsNullOrWhiteSpace(L5.Text) &&
                !string.IsNullOrWhiteSpace(L6.Text) &&
                !string.IsNullOrWhiteSpace(L7.Text) &&
                !string.IsNullOrWhiteSpace(L8.Text) &&
                !string.IsNullOrWhiteSpace(L9.Text))
            {
                MessageBox.Show("Draw!");
                Close();
            }

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (!string.IsNullOrWhiteSpace(control.Text))
                    control.Click -= label_Click;


            }



            Label cpu = labels[index];
            if (L1.Text != "" && L2.Text != "" && L3.Text != ""
                && L4.Text != "" && L5.Text != "" && L6.Text != ""
                && L7.Text != "" && L8.Text != "" && L9.Text != "")
            {
                PickSquare();
                return;
            }
            if (cpu.Text != "")
            {
                PickSquare();
                return;
            }

            cpu.Text = "X";
        }

        private void CheckForWin()
        {
            //Horizontal Check For O
            if (L1.Text == "O" && L2.Text == "O" && L3.Text == "O")
            { OWins(); }
            if (L4.Text == "O" && L5.Text == "O" && L6.Text == "O")
            { OWins(); }
            if (L7.Text == "O" && L8.Text == "O" && L9.Text == "O")
            { OWins(); }

            //Vertical Check For O
            if (L1.Text == "O" && L4.Text == "O" && L7.Text == "O")
            { OWins(); }
            if (L2.Text == "O" && L5.Text == "O" && L8.Text == "O")
            { OWins(); }
            if (L3.Text == "O" && L6.Text == "O" && L9.Text == "O")
            { OWins(); }

            //Diagonal Check For O
            if (L1.Text == "O" && L5.Text == "O" && L9.Text == "O")
            { OWins(); }
            if (L3.Text == "O" && L5.Text == "O" && L7.Text == "O")
            { OWins(); }

            //Horizontal Check For X
            if (L1.Text == "X" && L2.Text == "X" && L3.Text == "X")
            { XWins(); }
            if (L4.Text == "X" && L5.Text == "X" && L6.Text == "X")
            { XWins(); }
            if (L7.Text == "X" && L8.Text == "X" && L9.Text == "X")
            { XWins(); }

            //Vertical Check For X
            if (L1.Text == "X" && L4.Text == "X" && L7.Text == "X")
            { XWins(); }
            if (L2.Text == "X" && L5.Text == "X" && L8.Text == "X")
            { XWins(); }
            if (L3.Text == "X" && L6.Text == "X" && L9.Text == "X")
            { XWins(); }

            //Diagonal Check For X
            if (L1.Text == "X" && L5.Text == "X" && L9.Text == "X")
            { XWins(); }
            if (L3.Text == "X" && L5.Text == "X" && L7.Text == "X")
            { XWins(); }

            return;
        }

        private void OWins ()
        {
            MessageBox.Show("You Win!", "Congratulations");
            Close();
        }

        private void XWins()
        {
            MessageBox.Show("Good Try!");
            Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
