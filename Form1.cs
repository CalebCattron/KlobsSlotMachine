using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Play(int bet)
        {
            int winnings = CalculateWinnings(bet, RandomizeSlotMachine());
            credit += winnings;
            winningsTB.Text = "Winnings: " + winnings;
            creditWindow.Text = "Credits : " + credit + " (ඞ)";
        }

        private int[,] RandomizeSlotMachine()
        {
            Random random = new Random();
            int[,] slots = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    slots[i, j] = random.Next() % 9;
                    //Can change later.
                }
            }

            ImageReel(slots);

            return slots;
        }

        private void ImageReel(int[,] slots)
        {
            Image temp = null;
            var slotImages = new Dictionary<int, Image>()
            {
                { 0, WindowsFormsApp1.Properties.Resources.Mong},
                { 1, WindowsFormsApp1.Properties.Resources.Actual_Joker},
                { 2, WindowsFormsApp1.Properties.Resources.Spade},
                { 3, WindowsFormsApp1.Properties.Resources.Clubs},
                { 4, WindowsFormsApp1.Properties.Resources.Diamond},
                { 5, WindowsFormsApp1.Properties.Resources.Heart},
                { 6, WindowsFormsApp1.Properties.Resources.Coin},
                { 7, WindowsFormsApp1.Properties.Resources.Cherry},
                { 8, WindowsFormsApp1.Properties.Resources.Clover}
            };
            
            slotImages.TryGetValue(slots[0,0], out temp);
            slot1.Image = temp;

            slotImages.TryGetValue(slots[1, 0], out temp);
            slot2.Image = temp;

            slotImages.TryGetValue(slots[2, 0], out temp);
            slot3.Image = temp;

            slotImages.TryGetValue(slots[0, 1], out temp);
            slot4.Image = temp;

            slotImages.TryGetValue(slots[1, 1], out temp);
            slot5.Image = temp;

            slotImages.TryGetValue(slots[2, 1], out temp);
            slot6.Image = temp;

            slotImages.TryGetValue(slots[0, 2], out temp);
            slot7.Image = temp;

            slotImages.TryGetValue(slots[1, 2], out temp);
            slot8.Image = temp;

            slotImages.TryGetValue(slots[2, 2], out temp);
            slot9.Image = temp;
        }

        private int CalculateWinnings(int bet, int[,] slots)
        {
            int winnings = 0;
            int mult = 0;
            bool cherryWin = false;
            bool extraGames = false;

            var symbolMultiplier = new Dictionary<int, int>()
            {
                {0, 100},
                {1, 75},
                {2, 50},
                {3, 25},
                {4, 20},
                {5, 15},
                {6, 10},
                {7, 5},
                {8, 0},
                {9, 1}
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (slots[0, i] == slots[1, j])
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (slots[1, j] == slots[2, k])
                            {
                                if (slots[2, k] == 7)
                                {
                                    cherryWin = true;
                                }
                                else if (slots[2, k] == 8)
                                {
                                    extraGames = true;
                                    spin++;
                                    SpinAgain.Text = "" + spin;
                                }
                                symbolMultiplier.TryGetValue(slots[2,k], out mult);
                                winnings += (bet * mult);
                            }
                        }
                    }
                }
            }

            if (!cherryWin)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (slots[0, i] == 7)
                    {
                        winnings += bet;
                    }
                }
            }

            if (extraGames)
            {
                for (int i = 0; i < 5; i++)
                {
                    winnings += CalculateWinnings(bet, RandomizeSlotMachine());
                }
                extraGames = false;
            }

            cherryWin = false;

            return winnings;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public int credit = 100;
        public int spin = 0;

        private void bet1_Click(object sender, EventArgs e)
        {
            if (credit >= 1)
            {
                credit--;
                Play(1);
            }
        }

        private void bet10_Click(object sender, EventArgs e)
        {
            if (credit >= 10)
            {
                credit -= 10;
                Play(10);
            }
        }

        private void bet100_Click(object sender, EventArgs e)
        {
            if (credit >= 100)
            {
                credit -= 100;
                Play(100);
            }
        }

        private void bet1k_Click(object sender, EventArgs e)
        {
            if (credit >= 1000)
            {
                credit -= 1000;
                Play(1000);
            }
        }

        private void refill_Click(object sender, EventArgs e)
        {
            if (credit == 0)
            {
                credit = 10;
                creditWindow.Text = "Credits : " + credit + " (ඞ)";
            }
        }
    }
}
