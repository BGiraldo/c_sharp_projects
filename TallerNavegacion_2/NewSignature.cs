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
    public partial class NewSignature : Form
    {

        private SignatureController controller;

        public NewSignature()
        {
            InitializeComponent();
            controller = new SignatureController();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Thread hiloIntefaz = new System.Threading.Thread
                 (new System.Threading.ThreadStart(returnGradeList));
            this.Close();
            hiloIntefaz.SetApartmentState
                (System.Threading.ApartmentState.STA);
            hiloIntefaz.Start();
        }

        public void returnGradeList()
        {
            GradeList vtn = new GradeList();
            vtn.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(!String.IsNullOrEmpty(txtCode.Text) & !String.IsNullOrEmpty(txtName.Text)
                & !String.IsNullOrEmpty(txtPartial1.Text)
                & !String.IsNullOrEmpty(txtPartial2.Text)
                & !String.IsNullOrEmpty(txtPartial3.Text)
                & !String.IsNullOrEmpty(txtStudio1.Text)
                & !String.IsNullOrEmpty(txtStudio2.Text)
                & !String.IsNullOrEmpty(txtStudio3.Text))
            {


                String code = txtCode.Text;
                String name = txtName.Text;
                Grade workshop1 = new Grade(Convert.ToSingle(txtStudio1.Text),10); 
                Grade workshop2 = new Grade(Convert.ToSingle(txtStudio2.Text), 10);
                Grade workshop3 = new Grade(Convert.ToSingle(txtStudio3.Text), 10);
                Grade partial1 = new Grade(Convert.ToSingle(txtPartial1.Text), 20);
                Grade partial2 = new Grade(Convert.ToSingle(txtPartial2.Text), 20);
                Grade partial3 = new Grade(Convert.ToSingle(txtPartial3.Text), 30);

                Grade[] workshops = new Grade[] { workshop1, workshop2, workshop3};
                Grade[] partials = new Grade[] { partial1, partial2, partial3 };

                Signature signature = new Signature(code, name, workshops, partials);
                signature.Definitive = calculeDefinitive();

                bool res = controller.addSignature(signature);

                if (res)
                {
                    MessageBox.Show("Registered Successfully");
                    cleanFields();
                }
                else
                {
                    MessageBox.Show("Already exist a Signature with that code");
                }

            }
            else
            {
                MessageBox.Show("Please Complete the Fields");
            }


        }

        private float calculeDefinitive()
        {
            Grade workshop1 = new Grade(Convert.ToSingle(txtStudio1.Text), 10);
            Grade workshop2 = new Grade(Convert.ToSingle(txtStudio2.Text), 10);
            Grade workshop3 = new Grade(Convert.ToSingle(txtStudio3.Text), 10);
            Grade partial1 = new Grade(Convert.ToSingle(txtPartial1.Text), 20);
            Grade partial2 = new Grade(Convert.ToSingle(txtPartial2.Text), 20);
            Grade partial3 = new Grade(Convert.ToSingle(txtPartial3.Text), 30);

            float definitive = (workshop1.GradeN * (workshop1.Porcent / 100)
                                                + workshop2.GradeN * (workshop2.Porcent / 100)
                                                + workshop3.GradeN * (workshop3.Porcent / 100)
                                                + partial1.GradeN * (partial1.Porcent / 100)
                                                + partial2.GradeN * (partial2.Porcent / 100)
                                                + partial3.GradeN * (partial3.Porcent / 100));

            lbDefinitive.Text = "Definitive : " + definitive;

            return definitive;

        }

        public void verifyNumbers(TextBox t)
        {
            try
            {
                if (Convert.ToSingle(t.Text) >= 0 & Convert.ToSingle(t.Text) <= 5)
                {
                    calculeDefinitive();
                }
                else
                {
                    t.Text = "0.0";
                }
            }catch(System.FormatException ex)
            {
                t.Text = "0.0";
                MessageBox.Show("Please just write numbers");
            }
        }

       

        private void cleanFields()
        {
            txtCode.Text = "";
            txtName.Text = "";
            txtPartial1.Text = "0.0";
            txtPartial2.Text = "0.0";
            txtPartial3.Text = "0.0";
            txtStudio1.Text = "0.0";
            txtStudio2.Text = "0.0";
            txtStudio3.Text = "0.0";
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

        private void txtPartial1_KeyUp(object sender, KeyEventArgs e)
        {
            verifyNumbers(txtPartial1);
        }

        private void txtPartial2_KeyUp(object sender, KeyEventArgs e)
        {
            verifyNumbers(txtPartial2);
        }

        private void txtPartial3_KeyUp(object sender, KeyEventArgs e)
        {
            verifyNumbers(txtPartial3);
        }
    }
}
