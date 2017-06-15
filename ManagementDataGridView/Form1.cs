using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementDataGridView
{
    public partial class Form1 : Form
    {

        private TurnController controller;
        
        public Form1()
        {
            InitializeComponent();
            controller = new TurnController();
            addColumn();
        }

        public void addColumn()
        {
            dgvControl.Columns.Add("ColTurn", "Turn");
            dgvControl.Columns.Add("ColDocument", "Document");
            dgvControl.Columns.Add("ColName", "Name");
            dgvControl.Columns.Add("ColDate", "Date");
            dgvControl.ReadOnly = true;
  
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if(!(String.IsNullOrEmpty(txtDocument.Text) & String.IsNullOrEmpty(txtName.Text))){

                String document = txtDocument.Text;

                Turn turn  = new Turn(controller.obtainTurn(), document, DateTime.Now.ToString());

                controller.addTurn(turn);
                addToTable(turn);  

            }
            else
            {
                MessageBox.Show("Please Complete the Fields");
            }


        }


        public void addToTable(Turn turno)
        {
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                dgvControl.Rows.Add(turno.NumberTurn, turno.Document, txtName.Text, turno.Date);
                dgvControl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                cleanFields();
            }
            else
            {
                MessageBox.Show("Complete the field Name");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
             
                   dgvControl.Rows.RemoveAt(dgvControl.CurrentRow.Index);
            }catch(Exception ex)
            {
                MessageBox.Show("Please Select the all Rows to Remove");
            }
           
        }

        public void cleanFields()
        {
            txtDate.Text = "";
            txtDocument.Text = "";
            txtName.Text = "";
            txtTurn.Text = "";
        }

        private void dgvControl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int number = Convert.ToInt32(dgvControl[0, dgvControl.CurrentRow.Index].Value.ToString());
            String document = dgvControl[1, dgvControl.CurrentRow.Index].Value.ToString();
            String name = dgvControl[2, dgvControl.CurrentRow.Index].Value.ToString();
            String date = dgvControl[3, dgvControl.CurrentRow.Index].Value.ToString();

            txtDate.Text = date;
            txtDocument.Text = document;
            txtName.Text = name;
            txtTurn.Text = number.ToString();
        }
    }
}
