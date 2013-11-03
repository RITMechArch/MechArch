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
using System.Windows.Shapes;
using Microsoft.Expression.Encoder.Devices;
using WebcamControl;
using System.IO;
using System.Drawing.Imaging;

namespace MechArcher
{
    /// <summary>
    /// Interaction logic for Config.xaml
    /// </summary>
    public partial class Config : Window
    {
        private Binding bndg_1 = new Binding("SelectedValue");
        public Config()
        {
            InitializeComponent();
            
            bndg_1.Source = VidDvcsComboBox;

            // Find a/v devices connected to the machine.
            FindDevices();

            VidDvcsComboBox.SelectedIndex = 0;
        }

        private void FindDevices()
        {
            var vidDevices = EncoderDevices.FindDevices(EncoderDeviceType.Video);
            var audDevices = EncoderDevices.FindDevices(EncoderDeviceType.Audio);

            foreach (EncoderDevice dvc in vidDevices)
            {
                VidDvcsComboBox.Items.Add(dvc.Name);
            }
        }

        private void OK_click(object sender, RoutedEventArgs e)
        {
            MainWindow mainpage = (MainWindow)this.Tag;
            this.Tag = this.bndg_1;
            mainpage.show(bndg_1);
            this.Hide();
        }
        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            this.Close();
            ((MainWindow)this.Tag).Close();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                ((MainWindow)this.Tag).Close();
            }
            catch
            { }

            base.OnClosing(e);
        }
    }
}
