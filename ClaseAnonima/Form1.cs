using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseAnonima
{
    public partial class Form1 : Form
    {

        private ClsAnonima anonim;

        public Form1()
        {
            InitializeComponent();
            anonim = new ClsAnonima();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(anonim.probarAnonima()+"");
        }
    }
}
