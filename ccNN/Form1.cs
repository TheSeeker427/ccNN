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
        Network network;
        Network network2;
        
        Graphics mindGraphics;
        drawBrain drawer;
        drawBrain drawer2;

        Boolean isMouseDown = false;
        public Form1()
        {
            InitializeComponent();
            int[] dims = { 2, 3, 2 };
            network = new Network(10,10,1);
            //network2 = new Network(2, 3, 2);
            mindGraphics = this.panel1.CreateGraphics();
            drawer = new drawBrain(mindGraphics, network);
            drawer2 = new drawBrain(100, mindGraphics, network2);
            

            dataStore.init();

            panel1.MouseDown += Panel1_MouseDown;
            panel1.MouseUp += Panel1_MouseUp;
            panel1.MouseMove += Panel1_MouseMove;

        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMouseDown)
            panel1.Location = new Point(panel1.Location.X + (e.X), panel1.Location.Y + (e.Y));
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
        }

        int epoch = 0;
        Label[] inLabels;
        Label[] hiLabels;
        Label[] outLabels;

        double[] data1 = { 0.0, 1.0 };

        private void draw()
        {


            
            inLabels = new Label[2];
            hiLabels = new Label[3];
            outLabels = new Label[1];
            for (int i = 0; i < inLabels.Length; i++)
            {
                inLabels[i] = new Label();
                inLabels[i].Text = "hi";
                flowLayoutPanel1.Controls.Add(inLabels[i]);
            }
            for (int i = 0; i < hiLabels.Length; i++)
            {
                hiLabels[i] = new Label();
                hiLabels[i].Text = "hi";
                flowLayoutPanel2.Controls.Add(hiLabels[i]);
            }
            for (int i = 0; i < outLabels.Length; i++)
            {
                outLabels[i] = new Label();
                outLabels[i].Text = "hi";
                flowLayoutPanel3.Controls.Add(outLabels[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else
            {
                draw();
                timer1.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double[] and = ranAND();
            double[] t = { and[0], and[1] };
            double[] o = { and[2], and[3] };

            DataSet ds = new DataSet(t, o);
            Random r = new Random();
            network.Train(dataStore.toDataSet());
            //nn.go(t,o);
            
            for (int i = 0; i < inLabels.Length; i++)
            {
                inLabels[i].Text = "" + network.InputLayer[i].Value;
            }
            for (int i = 0; i < hiLabels.Length; i++)
            {
                hiLabels[i].Text = ""+ network.HiddenLayer[i].Value;
            }
            
            for (int i = 0; i < outLabels.Length; i++)
            {
                outLabels[i].Text = "" + network.OutputLayer[i].Value;
            }

            //double[] t2 = { network.OutputLayer[0].Value, network.OutputLayer[1].Value };
           // double[] o2 = { and[2], and[3] };

           // DataSet ds2 = new DataSet(t2, o2);
           // network2.Train(ds2);

            getAns(and);
            mindGraphics.Clear(Color.LightGray);
            drawer.update(trackBar1.Value);
           // drawer2.update(trackBar1.Value);
            label1.Text =  " Epoch: "+ epoch;
            epoch++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] x = { double.Parse(textBox1.Text.Split(' ')[0]), double.Parse(textBox1.Text.Split(' ')[1]), double.Parse(textBox1.Text.Split(' ')[2]) };
            network.Compute(x);
            for (int i = 0; i < inLabels.Length; i++)
            {
                inLabels[i].Text = "" + network.InputLayer[i].Value;
            }
            for (int i = 0; i < inLabels.Length; i++)
            {
                hiLabels[i].Text = "" + network.HiddenLayer[i].Value;
            }
            for (int i = 0; i < inLabels.Length; i++)
            {
                outLabels[i].Text = "" + network.OutputLayer[i].Value;
            }
            drawer.update(trackBar1.Value);
            //  getAns(x);
        }

        private void getAns(double[] input)
        {
            if(input.Length > 2)
            {
                label2.Text = input[2] + "";
                label3.Text = input[3] + "";
            }else
            {
                if(input[0] == input[1])
                {
                    label2.Text = "1";
                    label3.Text = "1";
                }else
                {
                    label2.Text = "1";
                    label3.Text = "1";
                }
            }
        }

        private double[] ranAND()
        {
            Random r = new Random();
            double[] and = new double[4];
            
            and[0] = r.Next(0, 2);
            and[1] = r.Next(0, 2);
            if(and[0] == and[1])
            {
                and[2] = and[3] = 1;
                
            }
            else
            {
                and[2] = and[3] = 0;
            }

            return and;

        }

       

        int interval = 10;
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = interval * trackBar2.Value;
        }
    }
}
