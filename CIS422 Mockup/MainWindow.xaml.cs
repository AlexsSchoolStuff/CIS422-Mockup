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
        List<String> lstRecentItems = new List<String>();
        List<String> lstLowStock = new List<String>();
        List<String> lstDynamic = new List<String>();
        List<String> lstViewInventory = new List<String>();


        public MainWindow() {
            InitializeComponent();
            PopulateLists();
            HiddenButtons();
            frameMain.Navigate(new MainPage(lstRecentItems, lstLowStock, lstDynamic));
        }

        public void PopulateLists() {

            //Recent items
            lstRecentItems.Add("DATE" + "\t" + "\t" + "USER" + "\t" + "ACTION" + "\t" + "\t" + "ITEM" + "\t" + "\t" + "DETAILS");
            //This is where you input data, I will just sample some data
            //Obviously this would be pulled from a database in the project, but for this it is just a hardcoded string formatted to look nice
            lstRecentItems.Add(DateTime.Now.ToString("d") + "\t" + "trrivet" + "\t" + "Add item" + "\t" + "IV Catheter" + "\t" + "+14");
            lstRecentItems.Add(DateTime.Now.ToString("d") + "\t" + "aawallac" + "\t" + "Consume item" + "\t" + "Gloves" + "\t \t" + "-12");
            lstRecentItems.Add(DateTime.Now.ToString("d") + "\t" + "jefeeney" + "\t" + "Use simulator" + "\t" + "Nurse Anna" + "\t" + "+1 Use");

            //Low Stock
            lstLowStock.Add("\t ITEM \t\t QUANTITY");
            lstLowStock.Add("\t Gloves \t \t 5");
            lstLowStock.Add("\t Needle Caps \t 10");

            //Dynamic Items
            lstDynamic.Add("\t ITEM \t\t TIMES UPDATED");
            lstDynamic.Add("\t Gloves \t\t 24");
            lstDynamic.Add("\t IV Catheter \t 19");

            //View Inventory
            //lstViewInventory.Add("\tName \t\t\t Category \t\t Quantity \t Location\t\t");
            lstViewInventory.Add("\tGloves \t\t\t Consumable \t\t 5 \t\t H112 Cabinet 13\t");
            lstViewInventory.Add("\tIV Catheter \t\t Consumable \t\t 50 \t\t H110 Drawer 4\t");
            lstViewInventory.Add("\tNurse Anne \t\t Simulator \t \t ");
            lstViewInventory.Add("\tNurse Anne \t\t Simulator \t \t ");
            lstViewInventory.Add("\tIV Pump \t\t Asset \t\t \t15 \t \tH112");
            lstViewInventory.Add("\tNurse Anne \t\t Simulator \t \t ");
            lstViewInventory.Add("\tIV Pump \t\t Asset \t\t \t15 \t \t H112");
            lstViewInventory.Add("\tGloves \t\t\t Consumable \t\t 5 \t\t H112 Cabinet 13\t");
            lstViewInventory.Add("\tGloves \t\t\t Consumable \t\t 5 \t\t H112 Cabinet 13\t");
            lstViewInventory.Add("\tIV Catheter \t\t Consumable\t \t 50 \t\t H110 Drawer 4\t");
            lstViewInventory.Add("\tIV Pump \t\t Asset \t\t\t 15 \t \tH112");
            lstViewInventory.Add("\tIV Pump \t\t Asset \t\t\t 15 \t \tH112");



        }
        public void VisibleButtons() {
            btnSave.Visibility = Visibility.Visible;
            btnCancel.Visibility = Visibility.Visible;
        }
        public void HiddenButtons() {
            btnSave.Visibility = Visibility.Hidden;
            btnCancel.Visibility = Visibility.Hidden;
        }



        private void MenuItem_Click(object sender, RoutedEventArgs e) {
            VisibleButtons();
            frameMain.Navigate(new AddItem());
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e) {
            VisibleButtons();
            frameMain.Navigate(new ViewInventory(lstViewInventory));
        }

        private void btnSave_Click(object sender, RoutedEventArgs e) {
            HiddenButtons();
            frameMain.Navigate(new MainPage(lstRecentItems, lstLowStock, lstDynamic));
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e) {
            HiddenButtons();
            frameMain.Navigate(new MainPage(lstRecentItems, lstLowStock, lstDynamic));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e) {
            VisibleButtons();
            frameMain.Navigate(new ConsumeItem());
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e) {
            VisibleButtons();
            frameMain.Navigate(new UseItem());
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e) {
            VisibleButtons();
            frameMain.Navigate(new Reports());
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e) {
            frameMain.Navigate(new Settings());
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e) {
            frameMain.Navigate(new CheckInOut());
        }
    }
}
