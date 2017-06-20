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

namespace TallerNavegacion_2
{
    public partial class SignIn : Form
    {

        private CreateProffesorController controller;

        public SignIn()
        {
            InitializeComponent();
            controller = new CreateProffesorController();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread hiloIntefaz = new System.Threading.Thread
                 (new System.Threading.ThreadStart(returnLogin));
            this.Close();
            hiloIntefaz.SetApartmentState
                (System.Threading.ApartmentState.STA);
            hiloIntefaz.Start();
        }

        public void returnLogin()
        {
            Login vtn = new Login();
            vtn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(!String.IsNullOrEmpty(txtName.Text) & !String.IsNullOrEmpty(txtPass.Text)
                & !String.IsNullOrEmpty(txtUser.Text) & !String.IsNullOrEmpty(txtCheckPass.Text))
            {

                String name = txtName.Text;
                String user = txtUser.Text;
                String pass = txtPass.Text;
                String repeatPass = txtCheckPass.Text;

                if (pass.Equals(repeatPass))
                {
                    Proffesor proffesor = new Proffesor(generateId(), name, user, pass);
                    bool res = controller.addedProffesor(proffesor);

                    if(res){
                        MessageBox.Show("Registered Successfully");
                        cleanFields();
                    }
                    else
                    {
                        MessageBox.Show("Already exist that user, please Change it to end");
                    }

                }
                else
                {
                    MessageBox.Show("The pass and verification of the pass do not match, please re-enter");
                }

            }
            else
            {
                MessageBox.Show("Please Complete the Fields");
            }


        }

        public int generateId()
        {
            if (LoginController.proffesors.Count == 0)
            {
                return 0;
            }

            return LoginController.proffesors.Last().Id + 1;
        }

        public void cleanFields()
        {
            txtCheckPass.Text = "";
            txtName.Text = "";
            txtPass.Text = "";
            txtUser.Text = "";
        }
    }
}
