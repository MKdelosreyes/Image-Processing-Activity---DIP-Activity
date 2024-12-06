using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcess2;
using WebCamLib;

namespace DIP_Activity
{
    public partial class Form3 : Form
    {
        Bitmap loaded, processed;
        ConvMatrix m;
        public Form3()
        {
            InitializeComponent();
        }

        private void Picture_Copy(ref Bitmap a, ref Bitmap b)
        {
            b = new Bitmap(a.Width, a.Height);
            Color pixel;
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    pixel = a.GetPixel(x, y);
                    b.SetPixel(x, y, pixel);
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = loaded;
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            processed.Save(saveFileDialog1.FileName);
        }
        private void resetBtn_Click(object sender, EventArgs e)
        {
            openBtn.Enabled = false;
            trackBar1.Visible = false;
            saveBtn.Enabled = false;
            auxBtn.Visible = true;
            auxBtn.Text = "Select Image Processing Filter in the Menu Strip";
            auxBtn.Enabled = false;
            trackBar1.Visible = false;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            filterBtn.Visible = false;
            tempLbl.Text = string.Empty;
        }

        private void sharpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempLbl.Text = "Sharpen";
            openBtn.Enabled = true;
            trackBar1.Visible = true;
            auxBtn.Text = "Adjust the slider to control image sharpness";
            auxBtn.Enabled = false;
            trackBar1.Minimum = 9;
            trackBar1.Maximum = 30;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            resetBtn.Enabled = true;
            saveBtn.Enabled = true;
            BitmapFilter.Sharpen(loaded, trackBar1.Value);
            pictureBox2.Image = loaded;
        }

        private void boxBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempLbl.Text = "Box Blur";
            openBtn.Enabled = true;
            trackBar1.Visible = false;
            auxBtn.Visible = false;
            filterBtn.Visible = true;
            filterBtn.Text = "Apply Box Blur Filter";
        }

        private void filterBtn_Click(object sender, EventArgs e)
        {
            resetBtn.Enabled = true;
            saveBtn.Enabled = true;
            if (tempLbl.Text == "Box Blur")
            {
                ConvMatrix m = new ConvMatrix();
                m.SetAll(1);
                m.Factor = 25;
                m.Offset = 0;
                BitmapFilter.Conv3x3(loaded, m);
                pictureBox2.Image = loaded;

                //int blurSize = trackBar1.Value; 
                //ConvMatrix m = new ConvMatrix();
                //m.SetAll(1);
                //m.Factor = blurSize * blurSize; 
                //BitmapFilter.Conv3x3(loaded, m);
                //pictureBox2.Image = loaded;
            }
            else if (tempLbl.Text == "Gaussian Blur")
            {
                ConvMatrix m = new ConvMatrix();
                m.TopLeft = 1; m.TopMid = 2; m.TopRight = 1;
                m.MidLeft = 2; m.Pixel = 4; m.MidRight = 2;
                m.BottomLeft = 1; m.BottomMid = 2; m.BottomRight = 1;
                m.Factor = 16;
                m.Offset = 0;

                BitmapFilter.Conv3x3(loaded, m);
                pictureBox2.Image = loaded;
            }
            else if (tempLbl.Text == "Edge Enhance")
            {
                ConvMatrix m = new ConvMatrix();
                m.TopLeft = 0; m.TopMid = -1; m.TopRight = 0;
                m.MidLeft = -1; m.Pixel = 5; m.MidRight = -1;
                m.BottomLeft = 0; m.BottomMid = -1; m.BottomRight = 0;
                m.Factor = 1;
                m.Offset = 0;

                BitmapFilter.Conv3x3(loaded, m);
                pictureBox2.Image = loaded;
            }
            else if (tempLbl.Text == "Emboss Laplascian")
            {
                ConvMatrix m = new ConvMatrix();
                m.TopLeft = -2; m.TopMid = -1; m.TopRight = 0;
                m.MidLeft = -1; m.Pixel = 1; m.MidRight = 1;
                m.BottomLeft = 0; m.BottomMid = 1; m.BottomRight = 2;
                m.Factor = 1;
                m.Offset = 64;

                BitmapFilter.Conv3x3(loaded, m);
                pictureBox2.Image = loaded;
            }
            else if (tempLbl.Text == "Emboss Lossy")
            {
                ConvMatrix m = new ConvMatrix();
                m.TopLeft = -1; m.TopMid = -1; m.TopRight = 0;
                m.MidLeft = -1; m.Pixel = 1; m.MidRight = 1;
                m.BottomLeft = 0; m.BottomMid = 1; m.BottomRight = 1;
                m.Factor = 1;
                m.Offset = 64;

                BitmapFilter.Conv3x3(loaded, m);
                pictureBox2.Image = loaded;
            }
            else if (tempLbl.Text == "Emboss Horizontal")
            {
                ConvMatrix m = new ConvMatrix();
                m.TopLeft = -1; m.TopMid = -1; m.TopRight = -1;
                m.MidLeft = 0; m.Pixel = 1; m.MidRight = 0;
                m.BottomLeft = 1; m.BottomMid = 1; m.BottomRight = 1;
                m.Factor = 1;
                m.Offset = 64;

                BitmapFilter.Conv3x3(loaded, m);
                pictureBox2.Image = loaded;
            }
            else if (tempLbl.Text == "Emboss Vertical")
            {
                ConvMatrix m = new ConvMatrix();
                m.TopLeft = -1; m.TopMid = 0; m.TopRight = 1;
                m.MidLeft = -1; m.Pixel = 1; m.MidRight = 1;
                m.BottomLeft = -1; m.BottomMid = 0; m.BottomRight = 1;
                m.Factor = 1;
                m.Offset = 64;

                BitmapFilter.Conv3x3(loaded, m);
                pictureBox2.Image = loaded;
            }
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempLbl.Text = "Gaussian Blur";
            openBtn.Enabled = true;
            trackBar1.Visible = false;
            auxBtn.Visible = false;
            filterBtn.Visible = true;
            filterBtn.Text = "Apply Gaussian Blur Filter";
        }

        private void edgeEnhanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempLbl.Text = "Edge Enhance";
            openBtn.Enabled = true;
            trackBar1.Visible = false;
            auxBtn.Visible = false;
            filterBtn.Visible = true;
            filterBtn.Text = "Apply Edge Enhance Filter";
        }

        private void laplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempLbl.Text = "Emboss Laplascian";
            openBtn.Enabled = true;
            trackBar1.Visible = false;
            auxBtn.Visible = false;
            filterBtn.Visible = true;
            filterBtn.Text = "Apply Emboss Laplascian";
        }

        private void lossyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempLbl.Text = "Emboss Lossy";
            openBtn.Enabled = true;
            trackBar1.Visible = false;
            auxBtn.Visible = false;
            filterBtn.Visible = true;
            filterBtn.Text = "Apply Emboss Lossy Filter";
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempLbl.Text = "Emboss Horizontal";
            openBtn.Enabled = true;
            trackBar1.Visible = false;
            auxBtn.Visible = false;
            filterBtn.Visible = true;
            filterBtn.Text = "Emboss Horizontal Filter";
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tempLbl.Text = "Emboss Vertical";
            openBtn.Enabled = true;
            trackBar1.Visible = false;
            auxBtn.Visible = false;
            filterBtn.Visible = true;
            filterBtn.Text = "Emboss Vertical Filter";
        }
    }
}
