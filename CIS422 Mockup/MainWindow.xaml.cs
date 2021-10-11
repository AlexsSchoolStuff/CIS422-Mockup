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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        List<String> lstMain = new List<String>();
        public MainWindow() {
            InitializeComponent();
            lstMain.Add("DATE" + "\t" + "\t" + "USER" + "\t" + "ACTION" + "\t" + "\t" + "ITEM" + "\t" + "\t" + "DETAILS");
            //This is where you input data, I will just sample some data
            //Obviously this would be pulled from a database in the project, but for this it is just a hardcoded string formatted to look nice
            lstMain.Add(DateTime.Now.ToString("d") + "\t" + "trrivet" + "\t" + "Add item" + "\t" + "IV Catheter" + "\t" + "+14");
            lstMain.Add(DateTime.Now.ToString("d") + "\t" + "aawallac" + "\t" + "Consume item" + "\t" + "Gloves" +  "\t \t" + "-12");
            lstMain.Add(DateTime.Now.ToString("d") + "\t" + "jefeeney" + "\t" + "Use simulator" + "\t" + "Nurse Anna" + "\t" + "+1 Use");

            frameMain.Navigate(new MainPage(lstMain));
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) {
            
            
        }
    }
}
