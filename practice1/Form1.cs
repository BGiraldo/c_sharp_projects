using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice1
{
    public partial class Form1 : Form
    {

        private Enumerated enumerate;

        public Form1()
        {
            InitializeComponent();
            enumerate = new Enumerated();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(enumerate.traerPosicionDia()));
        }
    }
}
