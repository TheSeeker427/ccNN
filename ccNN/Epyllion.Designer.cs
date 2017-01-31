using System;


namespace ccNN
{
    partial class Epyllion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Epyllion));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.epyImageList = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headBox = new System.Windows.Forms.PictureBox();
            this.Animationtimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headBox)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Cyan;
            this.richTextBox1.Location = new System.Drawing.Point(3, 202);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(202, 85);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // epyImageList
            // 
            this.epyImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("epyImageList.ImageStream")));
            this.epyImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.epyImageList.Images.SetKeyName(0, "head.png");
            this.epyImageList.Images.SetKeyName(1, "Body.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ccNN.Properties.Resources.Body;
            this.pictureBox1.Location = new System.Drawing.Point(54, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // headBox
            // 
            this.headBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.headBox.Image = global::ccNN.Properties.Resources.head;
            this.headBox.Location = new System.Drawing.Point(54, 12);
            this.headBox.Name = "headBox";
            this.headBox.Size = new System.Drawing.Size(100, 92);
            this.headBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.headBox.TabIndex = 2;
            this.headBox.TabStop = false;
            // 
            // Animationtimer
            // 
            this.Animationtimer.Enabled = true;
            this.Animationtimer.Tick += new System.EventHandler(this.Animationtimer_Tick);
            // 
            // Epyllion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(209, 297);
            this.Controls.Add(this.headBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Neuropol X Rg", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Cyan;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Epyllion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Epyllion";
            this.TransparencyKey = System.Drawing.Color.CornflowerBlue;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private EventHandler button1_Click;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox headBox;
        public System.Windows.Forms.ImageList epyImageList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer Animationtimer;
    }
}