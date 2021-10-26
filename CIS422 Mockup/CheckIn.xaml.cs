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
    /// Interaction logic for CheckIn.xaml
    /// </summary>
    public partial class CheckIn : Page {
        Frame currentFrame;
        public CheckIn() {
            InitializeComponent();
        }
        public CheckIn(Frame frame, List<String> lstCheckOutItems) {
            InitializeComponent();
            currentFrame = frame;
            foreach(String item in lstCheckOutItems) {
                lstAssetsCheckedOut.Items.Add(item);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            currentFrame.Navigate(new CheckInOut(currentFrame));
        }
    }
}
