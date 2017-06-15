using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerVehiculos1
{
    public partial class Form1 : Form
    {

        ClsParking controller;

        public Form1()
        {
            InitializeComponent();
            controller = new ClsParking();
            cargarCombo();
        }

        private void cargarCombo()
        {
            cbState.Items.Add("IN_PARKING_LOT");
            cbState.Items.Add("OUT_OF_THE_PARKING_LOT");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtPlaque2.Text))
            {
                Car car = controller.search(txtPlaque2.Text);

                if (car != null)
                {

                    if(car.Hour != 0)
                    {
                        double price = controller.calculatePrice(car.Hour);
                        MessageBox.Show("amount to be paid : $" + price + " pesos");
                        car.State = "OUT_OF_THE_PARKING_LOT";
                        controller.edit(car);
                    }
                    else
                    {
                        MessageBox.Show("Please Edit first the hour");
                    }

                   
                }
                else
                {
                    MessageBox.Show("Car Not Found");
                }

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPlaque2.Text))
            {
                Car car = controller.search(txtPlaque2.Text);

                if (car != null)
                {

                    txtHours.Text = Convert.ToString(car.Hour);

                    if (car.State.Equals("IN_PARKING_LOT"))
                    {
                        cbState.SelectedIndex = 0;
                    }
                    else
                    {
                        cbState.SelectedIndex = 1;
                    }

                }
                else
                {
                    MessageBox.Show("Car Not Found");
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtPlaque2.Text))
            {
                Car car = controller.search(txtPlaque2.Text);

                if (car != null)
                {

                    car.Hour = Convert.ToInt32(txtHours.Text);
                    car.State = cbState.SelectedItem.ToString();

                    bool edit = controller.edit(car);

                    if (edit)
                    {
                        MessageBox.Show("Edited Correctly");
                        cleanFields();
                    }
                    else
                    {
                        MessageBox.Show("Unable to edit");
                    }
                    
                 
                }
                else
                {
                    MessageBox.Show("Car Not Found");
                }

            }
            else
            {
                MessageBox.Show("Please Complete the Fields");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtPlaque2.Text))
            {
                Car car = controller.search(txtPlaque2.Text);

                if (car != null)
                {

                    bool res = controller.remove(car.Plaque);
                    if (res)
                    {
                        MessageBox.Show("Removed Correctly");
                        cleanFields();
                    }
                    else
                    {
                        MessageBox.Show("Error while deleting");
                    }

                }
                else
                {
                    MessageBox.Show("Car Not Found");
                }


            }

        }

        public void cleanFields()
        {
            txtHours.Text = "";
            cbState.SelectedIndex = 0;
        }


    }
}
