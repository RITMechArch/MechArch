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
        private const string ImgPath = @"C:\WebcamSnapshots";
        private const int MinCamFeedHeight = 1080;
        private const int MinCamFeedWidth = 1920;

        Config config = new Config();
        public MainWindow()
        {
            this.Hide();
            config.Tag = this;
            config.Show();

            InitializeComponent();

            if (!Directory.Exists(ImgPath))
            {
                Directory.CreateDirectory(ImgPath);
            }

            InitializeWebcam();
        }

        public void show(Binding bndg_1)
        {
            WebCamCtrl.SetBinding(Webcam.VideoDeviceProperty, bndg_1);
            base.Show();
        }

        private void InitializeWebcam()
        {
            Rect webcamDimensions = GetWebcamDimensions();
            int webcamHeight = Convert.ToInt16(webcamDimensions.Height);
            int webcamWidth = Convert.ToInt16(webcamDimensions.Width);

            WebCamCtrl.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            WebCamCtrl.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            WebCamCtrl.Height = webcamHeight;
            WebCamCtrl.Width = webcamWidth;

            WebCamCtrl.ImageDirectory = ImgPath;
            WebCamCtrl.PictureFormat = ImageFormat.Bmp;
            WebCamCtrl.FrameRate = 1;
            WebCamCtrl.FrameSize = new System.Drawing.Size(webcamWidth, webcamHeight);

            WebCamCtrl.StartCapture();
        }

        private Rect GetWebcamDimensions()
        {
            Rect workArea = SystemParameters.WorkArea;
            Rect dimensions = new Rect();

            if ( workArea.Height <= (2*MinCamFeedHeight) )
            {
                dimensions.Height = MinCamFeedHeight;
            }
            else
            {
                dimensions.Height = workArea.Height / 2;
            }

            if ( workArea.Width <=  MinCamFeedWidth )
            {
                dimensions.Width = MinCamFeedWidth;
            }
            else
            {
                dimensions.Width = workArea.Width;
            }

            return dimensions;
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

        private void EStopButton_Click(object sender, RoutedEventArgs e)
        {
            // Take snapshot of webcam image.
            WebCamCtrl.TakeSnapshot();
        }
		
		private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            // Take snapshot of webcam image.
            WebCamCtrl.TakeSnapshot();
        }
		
		private void RetractButton_Click(object sender, RoutedEventArgs e)
        {
            // Take snapshot of webcam image.
            WebCamCtrl.TakeSnapshot();
        }
		
		private void FireManualButton_Click(object sender, RoutedEventArgs e)
        {
            // Take snapshot of webcam image.
            WebCamCtrl.TakeSnapshot();
        }
		
		private void FireAutoButton_Click(object sender, RoutedEventArgs e)
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

        private void QueuePanel_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
