using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sobreescritura_Abstraccion
{
    public partial class Form1 : Form
    {

        private ClsB_Sobrescritura sobrescrita;

        public Form1()
        {
            InitializeComponent();
            sobrescrita = new ClsB_Sobrescritura();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sobrescrita.mostrarConsola();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sobrescrita.ejecutar()+"");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 1 ; i <= 25; i++)
            {
                System.Console.WriteLine(i+"");  
            }
        }
    }
}
