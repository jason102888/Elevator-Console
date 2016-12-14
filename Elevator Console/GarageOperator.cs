using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkALot
{
    public partial class Garage_Operator : Form
    {
        // Creating an operator object 
        Operators op = new Operators();

        public Garage_Operator()
        {
            InitializeComponent();
        }

        private void Garage_Opporator_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //op.GetCustomerData();
            // Not sure what this is?
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ask higgs wed on how to fix this issue... adding public static void fixes the error on the actual method but causes an issue for the Query....
            op.GetEmptySpaces();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            op.GetReservedSpaces();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            op.GetFullSpaces();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //op.SetPrice();
        }
    }
}
