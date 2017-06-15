using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String nit = txtNit.Text;
            String nombreEmpresa = txtNombreEmpresa.Text;
            String direccion = txtDireccion.Text;
            int numeroVeh = Convert.ToInt32(txtNumeroVehiculos.Text);
            int precioCupo = Convert.ToInt32(txtPrecioCupo.Text);

            ClsTransport transport = new ClsTransport(nit, nombreEmpresa, direccion, numeroVeh, precioCupo);

            MessageBox.Show("Nombre : " + transport.Nombre + "\n"
                                + "NIT : " + transport.Nit + "\n"
                                + "Dirección : " + transport.Direccion + "\n"
                                + "Número Vehiculos : " + transport.NumeroVehiculos + "\n"
                                + "Precio Cupo : " + transport.PrecioCupo);


        }
    }
}
