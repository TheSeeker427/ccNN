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
    public partial class BasicTextForm : Form
    {
        public BasicTextForm()
        {
            InitializeComponent();
        }

        public BasicTextForm(String text)
        {
            InitializeComponent();
            richTextBox1.Text = text;
        }

        private void BasicTextForm_Load(object sender, EventArgs e)
        {

        }
    }
}
