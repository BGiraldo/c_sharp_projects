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

namespace tryLogin
{
    public partial class Form2 : Form
    {

        private SigninController controller;

        public Form2()
        {
            InitializeComponent();
            controller = new SigninController();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(!(String.IsNullOrEmpty(txtApellido.Text) 
                & String.IsNullOrEmpty(txtCedula.Text) 
                & String.IsNullOrEmpty(txtNombre.Text)
                & String.IsNullOrEmpty(txtPass.Text)
                & String.IsNullOrEmpty(txtUser.Text)))
            {

                String name = txtNombre.Text;
                String lastName = txtApellido.Text;
                String document = txtCedula.Text;
                String user = txtUser.Text;
                String pass = txtPass.Text;

                User u = new User(name, lastName, document, user, pass);

                bool res = controller.checkIn(u);

                if (res)
                {
                    MessageBox.Show("Registeres Successfully");
                    cleanFields();
                }
                else
                {
                    MessageBox.Show("Already Exist user With that Document");
                }
            }
            else
            {
                MessageBox.Show("Please Complete the Fields");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread hiloIntefaz = new System.Threading.Thread
             (new System.Threading.ThreadStart(abrirInterfazSignin));
            this.Close();
            hiloIntefaz.SetApartmentState
                (System.Threading.ApartmentState.STA);
            hiloIntefaz.Start();
        }

        public void abrirInterfazSignin()
        {
            Form1 viewLog = new Form1();
            viewLog.ShowDialog();
        }

        public void cleanFields()
        {
            txtApellido.Text = "";
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtPass.Text = "";
            txtUser.Text = "";
        }

    }
}
