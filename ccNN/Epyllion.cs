
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using IronPython;
using ccNN.EpyllionChar;

namespace ccNN
{
    public partial class Epyllion : Form
    {
        bool isMouseDown = false;
        Point lastLocation;
        
        public Epyllion()
        {
            InitializeComponent();
            headBox.Paint += PictureBox1_Paint;
            epyImageList.Images[0] = Image.FromFile(@"C:\Users\carr4\Documents\Visual Studio 2015\Projects\ccNN\ccNN\Resources\head.png");
            //draw();
            epyInit();
            pictureBox1.MouseDown += PictureBox1_MouseDown;
            pictureBox1.MouseUp += PictureBox1_MouseUp;
            pictureBox1.MouseMove += PictureBox1_MouseMove;
            headBox.MouseDown += PictureBox1_MouseDown;
            headBox.MouseUp += PictureBox1_MouseUp;
            headBox.MouseMove += PictureBox1_MouseMove;

            CommandLine.init();
            richTextBox1.KeyUp += RichTextBox1_KeyUp;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            lastLocation = e.Location;
        }

        private void RichTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ConsoleSend();
            }
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        public void draw()
        {
            headBox.Refresh();
            Bitmap bmp = new Bitmap(headBox.Image);
            Graphics g = headBox.CreateGraphics();
            
            g.Clear(Color.CornflowerBlue);
            g.DrawImage(new Bitmap(epyImageList.Images[0]), 0, 0, 100, 100);
            g.Dispose();
            headBox.Invalidate();
            //pictureBox1.Image = bmp;

           
        }
        CharModel epy;

        public void epyInit()
        {
            epy = new CharModel();
            epy.head.location = headBox.Location;
            epy.head.size = headBox.Size;
            epy.body.location = pictureBox1.Location;
            epy.body.size = pictureBox1.Size;
        }

        public void epyUpdate()
        {
            headBox.Location = epy.head.location;
            headBox.Size = epy.head.size;

            pictureBox1.Size = epy.body.size;
            pictureBox1.Location = epy.body.location;
        }

        private void Animationtimer_Tick(object sender, EventArgs e)
        {
            epy.update();
            epyUpdate();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        int oldText = 0;
        private void ConsoleSend()
        {
            string text = richTextBox1.Text.Substring(oldText);
            richTextBox1.Text += "User: " + text;
            richTextBox1.Select(richTextBox1.Text.Length - 1, 0);
            richTextBox1.ScrollToCaret();

            

            richTextBox1.Text += CommandLine.ReadLine(text) + "\n\n";
            oldText = richTextBox1.Text.Length - 1;
            richTextBox1.Select(richTextBox1.Text.Length - 1, 0);
            richTextBox1.ScrollToCaret();
        }


    }
}
