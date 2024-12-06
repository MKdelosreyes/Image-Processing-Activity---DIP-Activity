using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Activity
{
    static class BasicDIP
    {
        //Contrasting Image
        public static void Equalisation(ref Bitmap a, ref Bitmap b, int degree)
        {
            int height = a.Height;
            int width = a.Width;
            int numSamples, histSum;
            int[] Ymap = new int[256];
            int[] hist = new int[256];
            int percent = degree;

            //Compute the histogram from the sub-image
            Color nakuha;
            Color gray;
            Byte graydata;

            //Compute grayscale
            for (int x = 0; x < a.Width; x++)
                for (int y = 0; y < a.Height; y++)
                {
                    nakuha = a.GetPixel(x, y);
                    graydata = (byte)((nakuha.R + nakuha.G + nakuha.B) / 3);
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    a.SetPixel(x, y, gray);
                }

            //Histogram id data
            for (int x = 0; x < a.Width; x++)
                for (int y = 0; y < a.Height; y++)
                {
                    nakuha = a.GetPixel(x, y);
                    hist[nakuha.R]++;
                }

            //remap the Ys, use the maximum contrast (percent == 100)
            //based on histogram equalization
            numSamples = (a.Width * a.Height);
            histSum = 0;
            for (int h = 0; h < 256; h++)
            {
                histSum += hist[h];
                Ymap[h] = histSum * 255 / numSamples;
            }

            //if desired contrast is not maximum (percent < 100), then adjusting the mapping
            if (percent < 100)
            {
                for (int h = 0; h < 256; h++)
                {
                    Ymap[h] = h + ((int)Ymap[h] - h) * percent / 100;
                }
            }

            b = new Bitmap(a.Width, a.Height);
            //enchance the region by remapping intensities
            for (int y = 0; y < a.Height; y++)
                for (int x = 0; x < a.Width; x++)
                {
                    //set the new value of the gray value
                    Color temp = Color.FromArgb(Ymap[a.GetPixel(x, y).R], Ymap[a.GetPixel(x, y).G], Ymap[a.GetPixel(x, y).B]);
                    b.SetPixel(x, y, temp);
                }
        }

        public static void Brigthness(ref Bitmap a, ref Bitmap b, int value)
        {
            b = new Bitmap(a.Width, a.Height);
            for (int i = 0; i < a.Width; i++) {
                for (int k = 0; k < a.Height; k++) { 
                    Color pixel = a.GetPixel(i, k);
                    Color changed;
                    if (value > 0)
                        changed = Color.FromArgb(Math.Min(pixel.R + value, 255), Math.Min(pixel.G + value, 255), Math.Min(pixel.B + value, 255));
                    else
                        changed = Color.FromArgb(Math.Min(pixel.R + value, 0), Math.Min(pixel.G + value, 0), Math.Min(pixel.B + value, 0));

                    b.SetPixel(i, k, changed);
                }
            }
        }

        public static void Histogram(ref Bitmap a, ref Bitmap b)
        {
            Color pixel;
            Color gray;
            Byte graydata;

            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    pixel = a.GetPixel(x, y);
                    graydata = (byte)((pixel.R + pixel.G + pixel.B) / 3);
                    gray = Color.FromArgb(graydata, graydata, graydata);
                    a.SetPixel(x, y, gray);
                }
            }
            //pictureBox2.Image = processed;
            int[] histData = new int[256];
            for (int x = 0; x < a.Width; x++)
            {
                for (int y = 0; y < a.Height; y++)
                {
                    pixel = a.GetPixel(x, y);
                    histData[pixel.R]++;
                }
            }

            b = new Bitmap(256, 800);
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < 800; y++)
                {
                    b.SetPixel(x, y, Color.White);
                }
            }
            //plotting points based from histdata
            for (int x = 0; x < 256; x++)
            {
                for (int y = 0; y < Math.Min(histData[x] / 5, b.Height - 1); y++)
                {
                    b.SetPixel(x, (b.Height - 1) - y, Color.Black);
                }
            }
        }
    }
}
