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

        public Garage_Operator()
        {
            InitializeComponent();
        }

        private void Garage_Opporator_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Operators.foo();
            // Not sure what this is?
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ask higgs wed on how to fix this issue... adding public static void fixes the error on the actual method but causes an issue for the Query....
            Operators.GetEmptySpaces();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Operators.GetReservedSpaces();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Operators.GetFullSpaces();
        }
    }
}
