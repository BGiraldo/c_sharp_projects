using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElementosGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String categorias = "";

            int seleccionado = cbCombo.SelectedIndex;

            if (seleccionado != -1)
            {

                if(seleccionado == 0)
                {

                    if (chbComedia.Checked)
                    {
                        categorias = categorias + "\n"
                                      + chbComedia.Text;
                    }

                    if (chbAccion.Checked)
                    {
                        categorias = categorias + "\n"
                                      + chbAccion.Text;
                    }

                    if (chbAventura.Checked)
                    {
                        categorias = categorias + "\n"
                                      + chbAventura.Text;
                    }

                    if (chbCiencia.Checked)
                    {
                        categorias = categorias + "\n"
                                      + chbCiencia.Text;
                    }

                }else if (seleccionado == 1)
                {
                    if (rbAccion.Checked)
                    {
                        categorias = categorias + "\n" + rbAccion.Text;
                    }

                    if (rbAventura.Checked)
                    {
                        categorias = categorias + "\n" + rbAventura.Text;
                    }

                    if (rbCiencia.Checked)
                    {
                        categorias = categorias + "\n" + rbCiencia.Text;
                    }

                    if (rbComedia.Checked)
                    {
                        categorias = categorias + "\n" + rbComedia.Text;
                    }

                }

                MessageBox.Show(categorias);

            }
            else
            {
                MessageBox.Show("Seleccione una Posición del combo");
            }

           


        }
    }
}
