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
    public partial class GradeList : Form
    {
        public GradeList()
        {
            InitializeComponent();
            lbWelcome.Text = "Welcome " + LoginController.proffesor.CompletName;
            loadTable();
        }

        public void loadTable()
        {
            foreach(var s in LoginController.proffesor.Signatures)
            {
                dgvSubjects.Rows.Add(s.Code, s.Name, s.Definitive);
            }
        }

        private void configurePorcentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread hiloIntefaz = new System.Threading.Thread
                (new System.Threading.ThreadStart(openSignaturePorcent));
            this.Close();
            hiloIntefaz.SetApartmentState
                (System.Threading.ApartmentState.STA);
            hiloIntefaz.Start();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread hiloIntefaz = new System.Threading.Thread
                (new System.Threading.ThreadStart(openNewSignature));
            this.Close();
            hiloIntefaz.SetApartmentState
                (System.Threading.ApartmentState.STA);
            hiloIntefaz.Start();
        }

        public void openSignaturePorcent()
        {
            try
            {
                SignatureCode vtn = new SignatureCode(dgvSubjects[0, dgvSubjects.CurrentRow.Index].Value.ToString());
                vtn.ShowDialog();
            }
            catch (System.NullReferenceException ex)
            {

                MessageBox.Show("Please First Add a new Subject and Select it");
            }
        }

        public void openNewSignature()
        {
            NewSignature vtn = new NewSignature();
            vtn.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtCodeSubject.Text) 
                & !txtCodeSubject.Text.Equals("Enter the code subject"))
            {

                // Code of the signature
                String code = txtCodeSubject.Text;



            }
            else
            {
                MessageBox.Show("Please Select of the table a Signature");  
            }

        }

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String code = dgvSubjects[0, dgvSubjects.CurrentRow.Index].Value.ToString();
            txtCodeSubject.Text = code;
        }
    }
}
