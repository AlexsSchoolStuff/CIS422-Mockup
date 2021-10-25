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
    /// Interaction logic for Reports.xaml
    /// </summary>
    public partial class Reports : Page {
        List<String> lstSimUses = new List<String>();
        List<String> lstActivity = new List<String>();
        List<String> lstLow = new List<String>();
        List<String> LstMaint= new List<String>();
        List<String> lstDynamic = new List<String>();
        List<String> lstChecked = new List<String>();
        public Reports() {
            InitializeComponent();
            PopulateReports();
            frameReports.Navigate(new Simulator_Uses(lstSimUses));
        }
        public void PopulateReports() {
            lstSimUses.Add("Simulator ⇅ \t\t Times Used ⇅ \t\t Hours Used ⇅");
            lstSimUses.Add("Nurse Anne \t\t 50 \t\t\t 200");
            lstSimUses.Add("Sim Man 3G \t\t 10 \t\t\t 54");
            lstSimUses.Add("Sim Mom \t\t 15 \t\t\t 80");

            lstActivity.Add(DateTime.Now.ToString("d") + "\t" + "trrivet" + "\t\t\t" + "Add item" + "\t" + "IV Catheter" + "\t" + "+14");
            lstActivity.Add(DateTime.Now.ToString("d") + "\t" + "aawallac" + "\t\t\t" + "Consume item" + "\t" + "Gloves" + "\t \t" + "-12");
            lstActivity.Add(DateTime.Now.ToString("d") + "\t" + "jefeeney" + "\t\t\t" + "Use simulator" + "\t" + "Nurse Anna" + "\t" + "+1 Use");

            lstLow.Add("\t Name \t\t Quantity\t");
            lstLow.Add("\t Gloves \t\t 7\t");
            lstLow.Add("\t Test \t\t 69\t");
            lstLow.Add("\t IV Catheter \t 0\t");


        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) {
            
            frameReports.Navigate(new Simulator_Uses(lstSimUses));
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e) {
            frameReports.Navigate(new ActivityLog(lstActivity));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e) {
            frameReports.Navigate(new LowStock(lstLow));
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e) {

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e) {

        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e) {

        }
    }
}
