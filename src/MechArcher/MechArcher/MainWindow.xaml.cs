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

        private NetworkController netController;
        private MachineStatus status;


        public MainWindow()
        {
            //this.Hide();
            InitializeComponent();

            status = new MachineStatus();
            netController = new NetworkController(status);
            // show();
        }

        //public void show(/*Binding bndg_1*/)
        /*{
            base.Show();
        }*/

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
            netController.updateMachineStatus();
            if ((status.getCurrentState() == MachineStatus.States.ARMED) && status.getFOptic() && !status.getROptic() && !status.getIsMoving())
            {
                netController.draw();
                netController.updateMachineStatus();
            }
        }
		
		private void RetractButton_Click(object sender, RoutedEventArgs e)
        {
            // Take snapshot of webcam image.
            netController.updateMachineStatus();
            if ((status.getCurrentState() == MachineStatus.States.DRAWN) && !status.getIsMoving())
            {
                netController.retract();
                netController.updateMachineStatus();
            }
        }
		
		private void FireManualButton_Click(object sender, RoutedEventArgs e)
        {
            netController.updateMachineStatus();
            if ((status.getCurrentState() == MachineStatus.States.DRAWN) && status.getFOptic() && status.getROptic() && !status.getIsMoving())
            {
                netController.fire();
                netController.updateMachineStatus();
            }
        }
		
		private void ClearTargetButton_Click(object sender, RoutedEventArgs e)
        {
            Camera.clearTarget();
        }

        public void SetTarget(object sender, RoutedEventArgs e)
        {
            Point target = Camera.getTarget();
            netController.aimY((int)target.Y);
            netController.aimX((int)target.X);
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
