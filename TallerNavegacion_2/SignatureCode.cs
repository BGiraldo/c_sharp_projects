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
    public partial class SignatureCode : Form
    {

        private String codeSignature;

        private SignatureController controller;

        public SignatureCode(String codeSignature)
        {
            InitializeComponent();
            controller = new SignatureController();
            this.codeSignature = codeSignature;
            loadGrades(codeSignature);
        }

        public void loadGrades(String code)
        {

            Signature s = controller.searchSubject(code);

            if (s != null)
            {
                txtStudio1.Text = s.StudioGrades[0].Porcent + "";
                txtStudio2.Text = s.StudioGrades[1].Porcent + "";
                txtStudio3.Text = s.StudioGrades[2].Porcent + "";
                txtP1.Text = s.PartialGrades[0].Porcent + "";
                txtP2.Text = s.PartialGrades[1].Porcent + "";
                txtP3.Text = s.PartialGrades[2].Porcent + "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread hiloIntefaz = new System.Threading.Thread
                (new System.Threading.ThreadStart(returnListSubject));
            this.Close();
            hiloIntefaz.SetApartmentState
                (System.Threading.ApartmentState.STA);
            hiloIntefaz.Start();
        }

        public void returnListSubject()
        {
            GradeList vtn = new GradeList();
            vtn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        public float calculeTotalPorcent()
        {
            float total = Convert.ToSingle(txtP1.Text +
                            txtP2.Text +
                            txtP3.Text +
                            txtStudio1.Text +
                            txtStudio2.Text +
                            txtStudio3.Text);
            return total;
                            
           }

        public void verifyNumbers(TextBox t)
        {
            try
            {
                if (calculeTotalPorcent()>100 | calculeTotalPorcent() < 0)
                {
                    t.Text = "";
                }

            }
            catch (System.FormatException ex)
            {
                t.Text = "";
                MessageBox.Show("Please just write numbers");
            }
        }


        private void txtStudio1_KeyUp(object sender, KeyEventArgs e)
        {
            verifyNumbers(txtStudio1);
        }

        private void txtStudio2_KeyUp(object sender, KeyEventArgs e)
        {
            verifyNumbers(txtStudio2);
        }

        private void txtStudio3_KeyUp(object sender, KeyEventArgs e)
        {
            verifyNumbers(txtStudio3);
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            verifyNumbers(txtP1);
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            verifyNumbers(txtP2);
        }

        private void txtP3_KeyUp(object sender, KeyEventArgs e)
        {
            verifyNumbers(txtP3);
        }
    }
}
