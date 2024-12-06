using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebCamLib;

namespace DIP_Activity
{
    public partial class Form2 : Form
    {
        Bitmap imageA, imageB, resultImage;
        Device[] devices;
        public Form2()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            imageB = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = imageB;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            imageA = new Bitmap(openFileDialog2.FileName);
            pictureBox2.Image = imageA;
        }

        private void Load_Background_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void Substract_Click(object sender, EventArgs e)
        {
            Color mygreen = Color.FromArgb(0, 255, 0);
            //int greygreen = (mygreen.R + mygreen.G + mygreen.B) / 3;
            int threshold = 50;

            resultImage = new Bitmap(imageA.Width, imageA.Height);

            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);

                    int diffR = Math.Abs(pixel.R - mygreen.R);
                    int diffG = Math.Abs(pixel.G - mygreen.G);
                    int diffB = Math.Abs(pixel.B - mygreen.B);

                    if (diffR < threshold && diffG < threshold && diffB < threshold)
                        resultImage.SetPixel(x, y, backpixel);
                    else
                        resultImage.SetPixel(x, y, pixel);
                }
            }
            pictureBox3.Image = resultImage;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            resultImage.Save(saveFileDialog1.FileName);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            devices = DeviceManager.GetAllDevices();
        }

        private void On_Webcam_Click(object sender, EventArgs e)
        {
            devices[0].ShowWindow(pictureBox1);
        }

        private void Off_Webcam_Click(object sender, EventArgs e)
        {
            devices[0].Stop();
        }
    }
}
