using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ccNN
{
    public partial class Form1 : Form
    {
        NeuralNetwork nn = new NeuralNetwork(2,2,2);
        public Form1()
        {
            InitializeComponent();
           

          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] t = { 0.0, 1.0 };
            double[] o = { 1.0, 0.0 };
            nn.go(t, o);
        }
    }
}
