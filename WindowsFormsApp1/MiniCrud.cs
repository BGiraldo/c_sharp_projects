using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        ClsAuto controller;

        public Form1()
        {
            InitializeComponent();
            controller = new ClsAuto();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(String.IsNullOrEmpty(txtPlaca.Text) & String.IsNullOrEmpty(txtMarca.Text)
                & String.IsNullOrEmpty(txtColor.Text)))
            {
                Auto auto = new Auto(txtPlaca.Text, txtMarca.Text, txtColor.Text);
                bool res = controller.registrar(auto);
                if (res)
                {
                    MessageBox.Show("Registrado Correctamente");
                }
                else
                {
                    MessageBox.Show("Ya existe Auto con esa placa");
                }
            }
            else
            {
                MessageBox.Show("Complete los campos");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtPlaca.Text))
            {
                String placa = txtPlaca.Text;
                Auto auto = controller.buscar(placa);

                if (auto != null)
                {
                    txtMarca.Text = auto.marca;
                    txtColor.Text = auto.color;
                }
                else
                {
                    MessageBox.Show("No se ha encontrado auto con esa placa");
                }
            }
            else
            {
                MessageBox.Show("Complete el campo placa");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtPlaca.Text))
            {
                String placa = txtPlaca.Text;
                Auto auto = controller.buscar(placa);

                if (auto != null)
                {
                    auto.color = txtColor.Text;
                    auto.marca = txtMarca.Text;
                    controller.editar(auto);

                    MessageBox.Show("Editado correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha encontrado auto con esa placa");
                }
            }
            else
            {
                MessageBox.Show("Complete el campo placa");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPlaca.Text))
            {
                String placa = txtPlaca.Text;
                Auto auto = controller.buscar(placa);

                if (auto != null)
                {
                    controller.remove(auto.placa);
                    MessageBox.Show("Eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("No se ha encontrado auto con esa placa");
                }
            }
            else
            {
                MessageBox.Show("Complete el campo placa");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Auto auto = controller.first();
            if (auto != null)
            {
                txtPlaca.Text = auto.placa;
                txtMarca.Text = auto.marca;
                txtColor.Text = auto.color;
            }
            else
            {
                MessageBox.Show("No se ha encontrado auto");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPlaca.Text))
            {
                String placa = txtPlaca.Text;
                Auto auto = controller.before(placa);

                if (auto != null)
                {
                    txtPlaca.Text = auto.placa;
                    txtMarca.Text = auto.marca;
                    txtColor.Text = auto.color;
                }
                else
                {
                    MessageBox.Show("Es el primero");
                }
            }
            else
            {
                MessageBox.Show("Complete el campo placa");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtPlaca.Text))
            {
                String placa = txtPlaca.Text;
                Auto auto = controller.next(placa);

                if (auto != null)
                {
                    txtPlaca.Text = auto.placa;
                    txtMarca.Text = auto.marca;
                    txtColor.Text = auto.color;
                }
                else
                {
                    MessageBox.Show("Es el ultimo");
                }
            }
            else
            {
                MessageBox.Show("Complete el campo placa");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Auto auto = controller.last();

            if (auto != null)
            {
                txtPlaca.Text = auto.placa;
                txtMarca.Text = auto.marca;
                txtColor.Text = auto.color;
            }
            else
            {
                MessageBox.Show("Es el ultimo");
            }
        }
    }
}
