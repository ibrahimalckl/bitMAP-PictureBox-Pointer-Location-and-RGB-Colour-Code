using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bitMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button btn1 = new Button();
            btn1.Text = "asd";
            btn1.Width = 100;
            this.Controls.Add(btn1);
        }

        Bitmap bmp;

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

                bmp = new Bitmap(pictureBox1.ImageLocation);
            }
        }

        //bool basili = false;
        //private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        //{
        //    basili = true;
        //}

        //private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        //{
        //    basili = false;
        //}

        bool asd;
        int xx, yy;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bmp != null)
            {
                xx = e.X;
                yy = e.Y;

                Color renk = bmp.GetPixel(xx, yy);

                label1.Text = xx.ToString();
                label2.Text = yy.ToString();
                label3.Text = renk.Name;
            }

            if (asd == true)
            {
                bmp.SetPixel(xx, yy, Color.White);
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            asd = true;

            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            asd = false;
        }    
    }
}
