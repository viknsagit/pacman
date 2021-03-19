using System;
using System.Windows.Forms;

namespace pacman
{
    public partial class Form1 : Form
    {
        int score = 0;

        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pacmanpic.Top -= 10;
                pacmanpic.Image = Properties.Resources.top1;

            }
            if (e.KeyCode == Keys.A)
            {
                pacmanpic.Left -= 10;
                pacmanpic.Image = Properties.Resources.leftp;
            }
            if (e.KeyCode == Keys.S)
            {
                pacmanpic.Top -= -10;
                pacmanpic.Image = Properties.Resources.top2;
            }
            if (e.KeyCode == Keys.D)
            {
                pacmanpic.Left -= -10;
                pacmanpic.Image = Properties.Resources.rightp;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pacmanpic.Image = Properties.Resources.сt1;

            }
            if (e.KeyCode == Keys.A)
            {
                pacmanpic.Left -= 10;
                pacmanpic.Image = Properties.Resources.crl2;
            }
            if (e.KeyCode == Keys.S)
            {
                pacmanpic.Top -= -10;
                pacmanpic.Image = Properties.Resources.сt2;
            }
            if (e.KeyCode == Keys.D)
            {
                pacmanpic.Left -= -10;
                pacmanpic.Image = Properties.Resources.crl1;
            }


            int eb1l = eb1.Left;

            lscore.Text = Convert.ToString(score);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int x1 = pacmanpic.Left;
            int y1 = pacmanpic.Top;
            int w1 = pacmanpic.Width;
            int h1 = pacmanpic.Height;
            int x2 = eb1.Left;
            int y2 = eb1.Top;
            int w2 = eb1.Width;
            int h2 = eb1.Height;
            if ((x1 + w1 > x2) & (x1 < x2 + w2) & (y1 + h1 == y2) & (y1 < y2 + h2)) ;
            {
                score++;
                eb1.Visible = false;

            }
        }
    }
}
