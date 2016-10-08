using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class MainForm : Form
    {
        public static int count = 0;
        int[,] arr = new int[3, 3];
        const int dim = 3;
        Button[,] btnArr;
        static int gameCounter = 0;
        static int lossCounter = 0;
        static int drawCounter = 0;
        static int winCounter = 0;
        public static int level = 0;

        public MainForm()
        {
            InitializeComponent();
            btnArr = new Button[3, 3] { { BtnA1, BtnA2, BtnA3 }, { BtnB1, BtnB2, BtnB3 }, { BtnC1, BtnC2, BtnC3 } };
            lblCounterLabel.Text = Convert.ToString(gameCounter);
            lblDraws.Text = Convert.ToString(drawCounter);
            lblLosses.Text = Convert.ToString(lossCounter);
        }

        private void BtnA1_Click(object sender, EventArgs e)
        {       
            Button geklickterButton = sender as Button;
            string play;
            bool end;
            int r, c;
            bool startAnew = false;

            play = count % 2 == 0 ? "O" : "X";
            geklickterButton.Text = play;
            geklickterButton.Click -= BtnA1_Click;

            GetCoord(geklickterButton, out c, out r);

            Logic.WriteToArray(arr, c, r, play);
            count++;

            if (count == 9)
            {
                MessageBox.Show("Unentschieden.");
                drawCounter++;
                startAnew = Reset();
            }
            if (!startAnew)
            {
                end = Logic.Win(arr);

                if (end)
                {
                    MessageBox.Show("Du hast gewonnen!");
                    winCounter++;
                    startAnew = Reset();
                }
                if (!startAnew)
                {               
                    play = count % 2 == 0 ? "O" : "X";
                    KI.KiTurn(arr, out c, out r);
                    btnArr[c, r].Text = play;
                    btnArr[c, r].Click -= BtnA1_Click;

                    Logic.WriteToArray(arr, c, r, play);

                    end = Logic.Win(arr);

                    if (end)
                    {
                        MessageBox.Show("Verloren hahahahahaha!");
                        lossCounter++;
                        startAnew = Reset();
                    }

                    if (!startAnew)
                    {
                        count++;
                    }
                }
            }
        }

        private void GetCoord(Button geklickterButton, out int c, out int r)
        {
            char cCh;
            r = -1;
            c = -1;

            r = geklickterButton.Name[geklickterButton.Name.Length - 1] - 49;
            cCh = geklickterButton.Name[geklickterButton.Name.Length - 2];

            switch (cCh)
            {
                case 'A':
                    c = 0;
                    break;

                case 'B':
                    c = 1;
                    break;

                case 'C':
                    c = 2;
                    break;

                default:
                    c = 0;
                    break;
            }
        }

        private bool Reset()
        {
            count = 0;
            gameCounter++;
            lblDraws.Text = Convert.ToString(drawCounter);
            lblLosses.Text = Convert.ToString(lossCounter);
            lblWins.Text = Convert.ToString(winCounter);
            lblCounterLabel.Text = Convert.ToString(gameCounter);
            foreach (var btn in btnArr)
            {
                btn.Text = "";
                btn.Click -= BtnA1_Click;
                btn.Click += BtnA1_Click;
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int n = 0; n < arr.GetLength(0); n++)
                {
                    arr[n, i] = 0;
                }
            }
            return true;
        }

        private void btnWinable_Click(object sender, EventArgs e)
        {
            level = 1;
            MessageBox.Show("Pussy...");
        }
    }
}
