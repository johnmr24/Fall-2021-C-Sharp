//John Reichenbach
//CS 285-001
//Trip Calculator
//11-22-2021

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles;
            double gallons;

            //if the milesTraveled can be converted to a double
            if (double.TryParse(milesTraveled.Text, out miles))
            {
                //if the gallons can be converted to a double
                if (double.TryParse(gallonsOfGasConsumed.Text, out gallons))
                {
                    //result is equal to the miles traveled divided by the gallons
                    //of gas consumed
                    double result = miles / gallons;

                    //sets the miles per gallon text equal to the result converted 
                    //to a string in the number format with 2 decimal places
                    milesPerGallon.Text = result.ToString("N");
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //resets all of the text boxes to empty
            destination.Text = "";
            milesTraveled.Text = "";
            gallonsOfGasConsumed.Text = "";
            milesPerGallon.Text = "";
        }
    }
}
