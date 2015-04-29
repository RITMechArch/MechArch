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
using System.IO;
using System.Drawing.Imaging;
// using Nikon;

namespace MechArcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string ImgPath = @"C:\WebcamSnapshots";
        // private const int MinCamFeedHeight = 1080;
        // private const int MinCamFeedWidth = 1920;
        private const int MinCamFeedHeight = 540;
        private const int MinCamFeedWidth = 860;

       // private NikonManager manager;
       // private NikonDevice camera;

        public MainWindow()
        {
            this.Hide();

            InitializeComponent();

            if (!Directory.Exists(ImgPath))
            {
                Directory.CreateDirectory(ImgPath);
            }

            InitializeWebcam();
            show();
        }

        public void show(/*Binding bndg_1*/)
        {
            base.Show();
        }

        private void InitializeWebcam()
        {
           //  manager = new NikonManager("Type0003.md3");
           //  manager.DeviceAdded += new DeviceAddedDelegate(manager_DeviceAdded);

            const string requiredDllFile = "NkdPTP.dll";
            string requiredDllPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName("Type0003.md3"), requiredDllFile);
            Console.WriteLine(requiredDllPath);
        }

        /*
        void manager_DeviceAdded(NikonManager sender, NikonDevice device)
        {
            Console.WriteLine("CAMERA ADDED");
            if (camera == null)
            {
                camera = device;
                camera.ImageReady += new ImageReadyDelegate(onImageReady);
                camera.CaptureComplete += new CaptureCompleteDelegate();

            }
        } */

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

        /*
        void onImageReady(NikonDevice sender, NikonImage image)
        {
            // TODO: Do something with 'image'
            Console.WriteLine(image.GetType());
        }

        void onCaptureComplete(NikonDevice sender)
        {
        } */

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void EStopButton_Click(object sender, RoutedEventArgs e)
        {
            /*NkMAIDCapInfo[] capInfo = camera.GetCapabilityInfo();
            foreach(NkMAIDCapInfo info in capInfo)
            {
                Console.WriteLine(info.GetDescription());
            }

            String filename = DateTime.Now.ToString();
            Console.WriteLine(filename);
            camera.Capture();*/
        }
		
		private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            // Take snapshot of webcam image.
            Console.WriteLine("TEST__________TEST__________TEST");
        }
		
		private void RetractButton_Click(object sender, RoutedEventArgs e)
        {
            // Take snapshot of webcam image.
        }
		
		private void FireManualButton_Click(object sender, RoutedEventArgs e)
        {
            // Take snapshot of webcam image.
        }
		
		private void FireAutoButton_Click(object sender, RoutedEventArgs e)
        {
            // Take snapshot of webcam image.
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            /*
            if (manager != null)
            {
                manager.Shutdown();

            } */
        }

        private void QueuePanel_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
