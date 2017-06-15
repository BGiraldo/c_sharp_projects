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
    public partial class Form1 : Form
    {

        private LoginController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new LoginController();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(String.IsNullOrEmpty(txtUser.Text) & String.IsNullOrEmpty(txtPass.Text)))
            {

                bool exist = controller.login(txtUser.Text, txtPass.Text);

                if (exist)
                {
                    
                    Thread hiloIntefaz = new System.Threading.Thread
                (new System.Threading.ThreadStart(abrirInterfazInit));
                    this.Close();
                    hiloIntefaz.SetApartmentState
                        (System.Threading.ApartmentState.STA);
                    hiloIntefaz.Start();
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
            else
            {
                MessageBox.Show("Please complete the fields");
            }

        }

        public void abrirInterfazInit()
        {
            Form3 viewLog = new Form3();
            viewLog.ShowDialog();
        }

        public void abrirInterfazSignin()
        {
            Form2 viewLog = new Form2();
            viewLog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Thread hiloIntefaz = new System.Threading.Thread
               (new System.Threading.ThreadStart(abrirInterfazSignin));
            this.Close();
            hiloIntefaz.SetApartmentState
                (System.Threading.ApartmentState.STA);
            hiloIntefaz.Start();

        }
    }
}
