using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSRMTool
{
    public static class BitmapMaker
    {
        public struct ColorRGB
        {
            public double red, green, blue;
        }

        public static Bitmap CreateBitMap(string fileName)
        {
            var bmp = new Bitmap(fileName);
            var graphics = Graphics.FromImage(bmp);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                graphics.DrawImage(bmp, new Point(0,0));
            }

            return bmp;
        } 

        public static Bitmap CreateBitMap(double[,] bitMapValues)
        {
            int xDimensions = bitMapValues.GetLength(0);
            int yDimensions = bitMapValues.GetLength(1);

            double min = bitMapValues.Cast<double>().Min();
            double max = bitMapValues.Cast<double>().Max();
            double range = max - min;

            byte bitMapByte;

            Bitmap bmp = new Bitmap(xDimensions, yDimensions);
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            
            unsafe
            {
                byte* bytePointer = (byte*) bmpData.Scan0;
                for (int j = 0; j < yDimensions; j++)
                {
                    for (int i = 0; i < xDimensions; i++)
                    {
                        bitMapByte = (byte) (255 * (bitMapValues[i, bmpData.Height - 1 - j] - min) / range);

                        for (int k = 0; k < 3; k++)
                            bytePointer[k] = bitMapByte;
                        bytePointer[3] = (byte)255;
                        bytePointer += 4;

                        // Slower method
                        /*double color = bitMapValues[i, j];
                        ColorRGB RGB = new ColorRGB() { red = color, green = color, blue = color };
                        bmp.SetPixel(i, j, Color.FromArgb(255, RGB.red, RGB.green, RGB.blue);*/
                    }
                    bytePointer += (bmpData.Stride - (bmpData.Width * 4));
                }
            }

            bmp.UnlockBits(bmpData);
            return bmp;
        }
    }
}
