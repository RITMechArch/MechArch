using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Expression.Encoder.Devices;
using WebcamControl;
using System.IO;
using System.Drawing.Imaging;

namespace MechArcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Config config = new Config();
        public MainWindow()
        {
            this.Hide();
            config.Tag = this;
            config.Show();

            InitializeComponent();

            string imgPath = @"C:\WebcamSnapshots";

            if (Directory.Exists(imgPath) == false)
            {
                Directory.CreateDirectory(imgPath);
            }

            WebCamCtrl.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            WebCamCtrl.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            WebCamCtrl.Height = 600;
            WebCamCtrl.Width = 800;

            WebCamCtrl.ImageDirectory = imgPath;
            WebCamCtrl.PictureFormat = ImageFormat.Bmp;
            WebCamCtrl.FrameRate = 24;
            WebCamCtrl.FrameSize = new System.Drawing.Size(800,600);

            WebCamCtrl.StartCapture();
        }

        public void show(Binding bndg_1)
        {
            WebCamCtrl.SetBinding(Webcam.VideoDeviceProperty, bndg_1);
            base.Show();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Display webcam video on control.
                WebCamCtrl.StartCapture();
            }
            catch (Microsoft.Expression.Encoder.SystemErrorException)
            {
                MessageBox.Show("Device is in use by another application");
            }
        }

        private void SnapshotButton_Click(object sender, RoutedEventArgs e)
        {
            // Take snapshot of webcam image.
            WebCamCtrl.TakeSnapshot();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                config.Close();
            }
            catch
            { }

            base.OnClosing(e);
        }
    }
}
