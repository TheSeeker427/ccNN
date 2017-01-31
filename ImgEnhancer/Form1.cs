using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ccNN;

namespace ImgEnhancer
{
    public partial class Form1 : Form
    {
        Bitmap orginal;
        Bitmap Enhanced;
        Bitmap TrainingGood;
        Bitmap TrainingBad;

        public Form1()
        {
            InitializeComponent();
            orginal = new Bitmap("sadf");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
