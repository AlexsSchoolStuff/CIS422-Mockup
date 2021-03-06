using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CIS422_Mockup {
    /// <summary>
    /// Interaction logic for CheckInOut.xaml
    /// </summary>
    public partial class CheckInOut : Page {
        Frame currentFrame;
        List<string> lstCheckOutItems = new List<String>();
        public CheckInOut() {
            InitializeComponent();
        }
        public CheckInOut(Frame frame) {
            InitializeComponent();
            currentFrame = frame;
            lstCheckOutItems.Add("Otoscope 1 \t\t H112 \t\t Cabinet 13 ");
            lstCheckOutItems.Add("IV Pump 4 \t\t H111 \t\t Cabinet 3");
            lstCheckOutItems.Add("MedicalThing1 \t\t H100 \t\t Drawer 2");


        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            currentFrame.Navigate(new CheckOut(currentFrame));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            currentFrame.Navigate(new CheckIn(currentFrame, lstCheckOutItems));
        }
    }
}
