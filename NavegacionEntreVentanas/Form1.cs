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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 vtn2 = new Form2();
            this.Hide();
            vtn2.ShowDialog();
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
            Form2 vtn2 = new Form2();
            vtn2.ShowDialog();
        }
    }
}
