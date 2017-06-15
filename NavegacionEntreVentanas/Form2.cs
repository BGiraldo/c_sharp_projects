using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavegacionEntreVentanas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 vtn1 = new Form1();
            this.Hide();
            vtn1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread hiloIntefaz = new System.Threading.Thread
                (new System.Threading.ThreadStart(abrirInterfaz));
            this.Close();
            hiloIntefaz.SetApartmentState
                (System.Threading.ApartmentState.STA);
            hiloIntefaz.Start();
        }

        private void abrirInterfaz()
        {
            Form1 vtn1 = new Form1();
            vtn1.ShowDialog();
        }
    }
}
