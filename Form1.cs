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
                pacmanpic.Top -= 10;
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
            lscore.Text = Convert.ToString(score);
            int eb1l = eb1.Left;
            int x1 = pacmanpic.Left;
            int y1 = pacmanpic.Top;
            int w1 = pacmanpic.Width;
            int h1 = pacmanpic.Height;

            int x2 = eb1.Left;
            int y2 = eb1.Top;
            int w2 = eb1.Width;
            int h2 = eb1.Height;

            int x3 = eb2.Left;
            int y3 = eb2.Top;
            int w3 = eb2.Width;
            int h3 = eb2.Height;

            int x4 = eb3.Left;
            int y4 = eb3.Top;
            int w4 = eb3.Width;
            int h4 = eb3.Height;

            int x5 = eb4.Left;
            int y5 = eb4.Top;
            int w5 = eb4.Width;
            int h5 = eb4.Height;



            for (int err = 0; score >= 0;)
            {


                if ((x1 + w1 >= x2) & (x2 + w2 >= x1) & (y1 + h1 >= y2) & (y2 + h2 >= y1))
                {
                    score++;
                    eb1.Visible = false;
                    eb1.Left = -100;

                }
                break;



            }
            for (int err = 0; score >= 0;)
            {


                if ((x1 + w1 >= x3) & (x3 + w3 >= x1) & (y1 + h1 >= y3) & (y3 + h3 >= y1))
                {
                    score++;
                    eb2.Visible = false;
                    eb2.Left = -100;
                }
                break;


            }
            for (int err = 0; score >= 0;)
            {


                if ((x1 + w1 >= x4) & (x4 + w4 >= x1) & (y1 + h1 >= y4) & (y4 + h4 >= y1))
                {
                    score++;
                    eb3.Visible = false;
                    eb3.Left = -100;
                }
                break;



            }
            for (int err = 0; score >= 0;)
            {


                if ((x1 + w1 >= x5) & (x5 + w5 >= x1) & (y1 + h1 >= y5) & (y5 + h5 >= y1))
                {
                    score++;
                    eb4.Visible = false;
                    eb4.Left = -100;

                }
                break;


            }
        }
    }
}
