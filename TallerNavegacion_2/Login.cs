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
    public partial class Login : Form
    {
        private LoginController controller;

        public Login()
        {
            InitializeComponent();
            controller = new LoginController();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtUser.Text) & !String.IsNullOrEmpty(txtPass.Text))
            {

                bool login = controller.login(txtUser.Text, txtPass.Text);

                if (login)
                {
                    Thread hiloIntefaz = new System.Threading.Thread
                  (new System.Threading.ThreadStart(openGradeList));
                    this.Close();
                    hiloIntefaz.SetApartmentState
                        (System.Threading.ApartmentState.STA);
                    hiloIntefaz.Start();
                }
                else
                {
                    MessageBox.Show("User Not Found");
                }
            }
            else
            {
                MessageBox.Show("Please complete the Fields");
            }

        }

        private void openGradeList()
        {
            GradeList vtn = new GradeList();
            vtn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread hiloIntefaz = new System.Threading.Thread
                 (new System.Threading.ThreadStart(openSignIn));
            this.Close();
            hiloIntefaz.SetApartmentState
                (System.Threading.ApartmentState.STA);
            hiloIntefaz.Start();
        }

        public void openSignIn()
        {
            SignIn vtn = new SignIn();
            vtn.ShowDialog();
        }
    }
}
