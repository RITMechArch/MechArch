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
        static Queue<int> pool = new Queue<int>();
        static double[,] filter = {{0.04,0.04,0.04,0.04,0.04}
                                  ,{0.04,0.04,0.04,0.04,0.04}
                                  ,{0.04,0.04,0.04,0.04,0.04}
                                  ,{0.04,0.04,0.04,0.04,0.04}
                                  ,{0.04,0.04,0.04,0.04,0.04}};

        static Bitmap newImage;
        static Bitmap oldImage;
        static int width;
        static int height;

        static void Main(string[] args)
        {
            string picture1;
            string picture2;

            DateTime time = DateTime.Now;

            Console.WriteLine("Picture 1");
            picture1 = "C:\\WebcamSnapshots\\picture21.bmp"; //Console.ReadLine();
            Console.WriteLine("Picture 2");
            picture2 = "C:\\WebcamSnapshots\\picture22.bmp"; //Console.ReadLine();

            Bitmap image1 = new Bitmap(picture1);
            Bitmap image2 = new Bitmap(picture2);

            SubtractImages(image1, image2, "C:\\WebcamSnapshots\\1");

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
                    Color color = Color.FromArgb(image1.GetPixel(x, y).ToArgb() - image2.GetPixel(x, y).ToArgb());
                    final.SetPixel(x, y, color);
                }
            }

            for(int x = 0; x < 5; ++x)
                final = SmoothImage(final);
            final.Save(outname + "final.bmp");
        }

        public static Bitmap SmoothImage(Bitmap image)
        {
            oldImage = image;
            newImage = new Bitmap(image);
            List<Thread> threads = new List<Thread>();
            height = image.Height;
            width = image.Width;

            for (int y = 0; y < height; ++y)
            {
                pool.Enqueue(y);
                Thread thread = new Thread(new ThreadStart(runRow));
                thread.Start();
                threads.Add(thread);
                /*for (int x = 0; x < image.Width; ++x)
                {
                    double total = 0;
                    int size = (int)Math.Sqrt(filter.Length) / 2;

                    for (int x2 = -1 * size; x2 < size; ++x2)
                    {
                        for (int y2 = -1 * size; y2 < size; ++y2)
                        {
                            total += image.GetPixel((x < size || x > image.Width - size ? x : x + x2), (y < size || y >= image.Height - size? y : y + y2)).ToArgb() * filter[x2 + size, y2 + size];
                        }
                    }

                    newMap.SetPixel(x, y, Color.FromArgb((int)total));
                }*/
            }

            foreach (Thread t in threads)
            {
                t.Join();
            }

            return newImage;
        }

        public static void runRow()
        {
            Bitmap newmap;
            //DateTime time = DateTime.Now;
            Color[] colors = new Color[width];
            lock (oldImage)
            {
                newmap = new Bitmap(oldImage);
            }

            int y = pool.Dequeue();
            for (int x = 0; x < width; ++x)
            {
                double total = 0;
                int size = (int)Math.Sqrt(filter.Length) / 2;

                for (int x2 = -1 * size; x2 < size; ++x2)
                {
                    for (int y2 = -1 * size; y2 < size; ++y2)
                    {
                        total += newmap.GetPixel((x < size || x > width - size ? x : x + x2), (y < size || y >= height - size ? y : y + y2)).ToArgb() * filter[x2 + size, y2 + size];
                    }
                }

                colors[x] = Color.FromArgb((int)total);
            }

            lock (newImage)
            {
                for (int x = 0; x < width; ++x)
                {
                    newImage.SetPixel(x, y, colors[x]);
                }
            }

            //Console.WriteLine("Thread " + y + ": " + DateTime.Now.Subtract(time).TotalSeconds);
            Thread.CurrentThread.Abort();
        }
    }
}
