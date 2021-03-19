using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
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
        }
        private void eatb (object sender)
        {
            if (true)
            {

            }
        }
            

            
        
    }
}
