using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenusDesplegables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rojoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.ForeColor = Color.Red;
        }

        private void azulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.ForeColor = Color.Blue;
        }

        private void verdeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.ForeColor = Color.Green;
        }

        private void amarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.BackColor = Color.Yellow;
        }

        private void negroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.BackColor = Color.Gray;
        }

        private void blacoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.BackColor = Color.White;
        }

        private void pequeñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.Font = new Font("Calibri", 12);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.Font = new Font("Sans Serif", 18);
        }

        private void grandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtTexto.Font = new Font("Oswald", 24);
        }
    }
}
