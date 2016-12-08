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
        }
    }
}
