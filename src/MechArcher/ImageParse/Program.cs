using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Drawing;
using System.Threading;

namespace ImageParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string picture1;

            DateTime time = DateTime.Now;

            Console.WriteLine("Picture 1");
            picture1 = "C:\\WebcamSnapshots\\" + Console.ReadLine(); ;

            Bitmap image1 = new Bitmap(picture1);

            //SubtractImages(image1, image2, "C:\\WebcamSnapshots\\1");

            filterImage(image1, "C:\\WebcamSnapshots\\1");

            Console.WriteLine(DateTime.Now.Subtract(time).TotalSeconds);
            Console.Read();
        }

        public static void SubtractImages(Bitmap image1, Bitmap image2, string outname)
        {
            Bitmap final = new Bitmap(image1);

            for (int y = 0; y < image1.Height; ++y)
            {
                for (int x = 0; x < image1.Width; ++x)
                {
                    Color color = Color.FromArgb( image1.GetPixel(x, y).ToArgb() - image2.GetPixel(x, y).ToArgb());

                    if (color.GetBrightness() > 0.65 && color.A != 0)
                        final.SetPixel(x, y, Color.Black);
                    else
                        final.SetPixel(x, y, Color.White);
                }
            }
            final.Save(outname + "final.bmp");
        }

        public static void filterImage(Bitmap image, string outname)
        {
            Bitmap final = new Bitmap(image);

            for (int y = 0; y < image.Height; ++y)
            {
                for (int x = 0; x < image.Width; ++x)
                {
                    Color color = image.GetPixel(x, y);
                    if (color.GetBrightness() > 0.85 && color.A != 0)
                        final.SetPixel(x, y, Color.Black);
                    else
                        final.SetPixel(x, y, Color.Transparent);
                }
            }
            final.Save(outname + "final.bmp");
        }
    }
}
