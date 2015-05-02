//
// This work is licensed under a Creative Commons Attribution 3.0 Unported License.
//
// Thomas Dideriksen (thomas@dideriksen.com)
//

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
using System.Diagnostics;
using System.ComponentModel;
using System.Reflection;
using Nikon;

namespace testapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static Point NO_TARGET = new Point();
        private Point target = NO_TARGET;
        private Ellipse targetMarker = null;
        private Ellipse targetMarker2 = null;
        
        private MachineStatus status;
        private NetworkController netController;

        private double canvasWidth;
        private double canvasHeight;

        private Canvas canvas = null;

        public MainWindow()
        {
            InitializeComponent();
            StatusText.Text = "System starting...";

            status = new MachineStatus();
            netController = new NetworkController(status);
            updateStatusText();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Model model = this.Resources["Model"] as Model;

            if (model != null)
            {
                model.Shutdown();
            }

            base.OnClosing(e);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textBox.ScrollToEnd();
        }

        object GetDataContext(object sender)
        {
            FrameworkElement element = sender as FrameworkElement;

            if (element != null)
            {
                return element.DataContext;
            }

            return null;
        }

        private void Button_StartLiveView_Click(object sender, RoutedEventArgs e)
        {
            ObjectModel model = GetDataContext(sender) as ObjectModel;

            if (model != null)
            {
                model.StartLiveView();
            }
        }

        private void Button_StopLiveView_Click(object sender, RoutedEventArgs e)
        {
            ObjectModel model = GetDataContext(sender) as ObjectModel;

            if (model != null)
            {
                model.StopLiveView();
            }
        }

        private void Button_Execute_Click(object sender, RoutedEventArgs e)
        {
            CapModel model = GetDataContext(sender) as CapModel;

            if (model != null)
            {
                model.Start();
            }
        }

        private void EStopButton_Click(object sender, RoutedEventArgs e)
        {
            netController.eStop();
            updateStatusText();
        }

        private void DrawButton_Click(object sender, RoutedEventArgs e)
        {
            netController.updateMachineStatus();
            if (status.getCurrentState() == MachineStatus.States.ARMED && status.getFOptic() && !status.getROptic())
            {
                netController.draw();
            }
        }

        private void RetractButton_Click(object sender, RoutedEventArgs e)
        {
            netController.updateMachineStatus();
            if ((status.getCurrentState() == MachineStatus.States.DRAWN) && !status.getIsMoving())
            {
                netController.retract();
                netController.updateMachineStatus();
            }
            updateStatusText();
        }

        private void FireButton_Click(object sender, RoutedEventArgs e)
        {
            netController.updateMachineStatus();
            if ((status.getCurrentState() == MachineStatus.States.DRAWN) && status.getFOptic() && status.getROptic() && !status.getIsMoving())
            {
                netController.fire();
                netController.updateMachineStatus();
            }
            if (status.getCurrentState() == MachineStatus.States.IDLE || status.getCurrentState() == MachineStatus.States.ARMED)
            {
                netController.center();
            }
            updateStatusText();
        }

        private void CenterButton_Click(object sender, RoutedEventArgs e)
        {
            if (status.getCurrentState() == MachineStatus.States.IDLE || status.getCurrentState() == MachineStatus.States.ARMED)
            {
                netController.center();
            }
            updateStatusText();
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ClearTarget();
            updateStatusText();
        }

        private void ClearTarget()
        {
            if (canvas != null && target != NO_TARGET)
            {
                canvas.Children.Remove(targetMarker);
                canvas.Children.Remove(targetMarker2);
                target = NO_TARGET;
            }
        }

        private void SetButton_Click(object sender, RoutedEventArgs e)
        {
            Point scaledPoint = GetScaledPosition(target, canvasWidth, canvasHeight);
            int x = (int) scaledPoint.X;
            int y = (int) scaledPoint.Y;
            netController.aimY(y);
            netController.aimX(x);
            updateStatusText();
        }

        private void LiveFeed_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Image image = (Image) sender;
            canvasWidth = image.ActualWidth;
            canvasHeight = image.ActualHeight;
            Point pixelClicked = e.GetPosition(image);
            Canvas canvas = (Canvas)image.Parent;
            if (this.canvas == null)
            {
                this.canvas = canvas;
            }
            if (target != NO_TARGET)
            {
                canvas.Children.Remove(targetMarker);
                canvas.Children.Remove(targetMarker2);
            }
            target = pixelClicked;

            targetMarker = new Ellipse();
            targetMarker.Height = 30;
            targetMarker.Width = 30;
            targetMarker.StrokeThickness = 3;
            targetMarker.Stroke = Brushes.Red;
            canvas.Children.Add(targetMarker);
            Canvas.SetLeft(targetMarker, target.X - 15);
            Canvas.SetTop(targetMarker, target.Y - 15);

            targetMarker2 = new Ellipse();
            targetMarker2.Height = 6;
            targetMarker2.Width = 6;
            targetMarker2.StrokeThickness = 3;
            targetMarker2.Stroke = Brushes.Red;
            canvas.Children.Add(targetMarker2);
            Canvas.SetLeft(targetMarker2, target.X - 3);
            Canvas.SetTop(targetMarker2, target.Y - 3);

            Point scaledPoint = GetScaledPosition(target, canvasWidth, canvasHeight);
            int x = (int)scaledPoint.X;
            int y = (int)scaledPoint.Y;
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
            updateStatusText();
        }

        private Point GetScaledPosition(Point pixel, double width, double height)
        {
            double xScaleFactor = 8192 / width;
            double yScaleFactor = 4096 / height;
            double newX = -1 * ((pixel.X * xScaleFactor) - 4096);
            double newY = (pixel.Y * yScaleFactor);
            return new Point(newX, newY);
        }

        private void updateStatusText()
        {
            netController.updateMachineStatus();
            String statusText = "Current Frame State: " + status.getCurrentState().ToString() + "\n";
            statusText += "Front Optic Sensor: ";
            if (status.getFOptic())
            {
                statusText += "Arrow Present\n";
            }
            else
            {
                statusText += "No Arrow\n";
            }
            statusText += "Rear Optic Sensor: ";
            if(status.getROptic())
            {
                statusText += "Arrow Present\n";
            }
            else
            {
                statusText += "No Arrow\n";
            }

            StatusText.Text = statusText;
        }
    }

    public class ValidatorBase<T> : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            string str = value as string;

            if (str == null)
            {
                return new ValidationResult(false, "Value can't be null");
            }

            var converter = TypeDescriptor.GetConverter(typeof(T));

            if (converter != null)
            {
                try
                {
                    T dummy = (T)converter.ConvertFromString(str);
                    return new ValidationResult(true, null);
                }
                catch (Exception)
                {
                    return new ValidationResult(false, "Failed to parse value");
                }
            }
            else
            {
                return new ValidationResult(false, "Failed to parse value");
            }
        }
    }

    public class UnsignedValidator : ValidatorBase<uint> { }
    public class IntegerValidator : ValidatorBase<int> { }
    public class FloatValidator : ValidatorBase<double> { }

    public class ConverterBase<T> : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                return value.ToString();
            }
            else
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string str = value as string;
            var converter = TypeDescriptor.GetConverter(typeof(T));

            if (str != null && converter != null)
            {
                try
                {
                    return (T)converter.ConvertFromString(str);
                }
                catch (Exception)
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

    }

    public class UnsignedToString : ConverterBase<uint> { }
    public class IntegerToString : ConverterBase<int> { }
    public class FloatToString : ConverterBase<double> { }

    public class BoolToVisibility : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            bool input = (bool)value;
            return input ? Visibility.Visible : Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class CapTypeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EnumTemplate { get; set; }
        public DataTemplate StringTemplate { get; set; }
        public DataTemplate RangeTemplate { get; set; }
        public DataTemplate GenericTemplate { get; set; }
        public DataTemplate ProcessTemplate { get; set; }
        public DataTemplate BooleanTemplate { get; set; }
        public DataTemplate UnsignedTemplate { get; set; }
        public DataTemplate IntegerTemplate { get; set; }
        public DataTemplate FloatTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            eNkMAIDCapType type = (item as CapModel).CapType;

            switch (type)
            {
                case eNkMAIDCapType.kNkMAIDCapType_Enum:
                    return EnumTemplate;

                case eNkMAIDCapType.kNkMAIDCapType_Range:
                    return RangeTemplate;

                case eNkMAIDCapType.kNkMAIDCapType_String:
                    return StringTemplate;

                case eNkMAIDCapType.kNkMAIDCapType_Process:
                    return ProcessTemplate;

                case eNkMAIDCapType.kNkMAIDCapType_Boolean:
                    return BooleanTemplate;

                case eNkMAIDCapType.kNkMAIDCapType_Unsigned:
                    return UnsignedTemplate;

                case eNkMAIDCapType.kNkMAIDCapType_Integer:
                    return IntegerTemplate;

                case eNkMAIDCapType.kNkMAIDCapType_Float:
                    return FloatTemplate;

                default:
                    return GenericTemplate;
            }
        }
    }
}
