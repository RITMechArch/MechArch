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
using Nikon;

namespace MechArcher
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class CameraController : UserControl
    {
        private static Point NO_TARGET = new Point();
        private Point target = NO_TARGET;
        private Ellipse targetMarker = null;

        private NikonManager manager = null;
        private NikonDevice camera = null;

        public CameraController()
        {
            InitializeComponent();
            InitializeCameraFeed();
        }

        private void HandleClose(DependencyPropertyChangedEventArgs e)
        {

        }

        public void InitializeCameraFeed()
        {
            manager = new NikonManager("Type0003.md3");
            manager.DeviceAdded += new DeviceAddedDelegate(manager_DeviceAdded);
        }


        void manager_DeviceAdded(NikonManager sender, NikonDevice device)
        {
            camera = device;
            
            // Set shooting mode to 'continuous, highspeed'
            NikonEnum shootingMode = camera.GetEnum(eNkMAIDCapability.kNkMAIDCapability_ShootingMode);
            shootingMode.Index = (int)eNkMAIDShootingMode.kNkMAIDShootingMode_CH;
            camera.SetEnum(eNkMAIDCapability.kNkMAIDCapability_ShootingMode, shootingMode);

        }


        public void clearTarget()
        {
            if (target != NO_TARGET)
            {
                canvas.Children.Remove(targetMarker); 
                target = NO_TARGET;
            }
        }

        public void MouseClick(Object sender, MouseButtonEventArgs e)
        {
            if (target != NO_TARGET)
            {
                canvas.Children.Remove(targetMarker);
            }
            Point pixelClicked = e.GetPosition(this);
            target = pixelClicked;

            targetMarker = new Ellipse();
            
            targetMarker.Height = 30;
            targetMarker.Width = 30;
            targetMarker.StrokeThickness = 3;
            targetMarker.Stroke = Brushes.Red;
            canvas.Children.Add(targetMarker);
            Canvas.SetLeft(targetMarker, target.X-15);
            Canvas.SetTop(targetMarker, target.Y-15);

            Console.WriteLine(getTarget());
        }

        public Point getTarget()
        {
            return GetScaledPosition(target);
        }

        private Point GetScaledPosition(Point pixel)
        {
            double xScaleFactor = 8192 / this.ActualWidth;
            double yScaleFactor = 4096 / this.ActualHeight;
            int newX = -1 * ((int) (pixel.X * xScaleFactor) - 4096);
            int newY = 4096 - (int) (pixel.Y * yScaleFactor);
            return new Point(newX, newY);
        }
    }
}
