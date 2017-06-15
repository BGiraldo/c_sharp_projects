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
    public partial class Form2 : Form
    {
        ClsParking controller;

        public Form2()
        {
            InitializeComponent();
            controller = new ClsParking();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 vtn1 = new Form1();
            vtn1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(txtPlaque1.Text))
            {
                Car car = controller.search(txtPlaque1.Text);
                if (car == null)
                {
                    Car newCar = new Car(txtPlaque1.Text, 0, "IN_PARKING_LOT");
                    ClsParking.cars.AddLast(newCar);
                    MessageBox.Show("Added Correctly");
                }
                else 
                {

                    MessageBox.Show("The car is already Added");
                }
            }
            else
            {
                MessageBox.Show("Fill out please the plate field");
            }
        }
    }
}
