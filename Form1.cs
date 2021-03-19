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
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                pacmanpic.Top -= 10;
            }
            if (e.KeyCode == Keys.A)
            {
                pacmanpic.Left -= 10;
            }
            if (e.KeyCode == Keys.S)
            {
                pacmanpic.Top -= -10;
            }
            if (e.KeyCode == Keys.D)
            {
                pacmanpic.Left -= -10;
            }
        }
    }
}
