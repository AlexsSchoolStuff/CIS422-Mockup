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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Page {

        List<String> lstCurrentUsers = new List<String>();
        List<String> lstCurrentCategories = new List<String>();
        List<String> lstCurrentSuppliers = new List<String>();



        public Settings() {
            InitializeComponent();
            lstCurrentUsers.Add("Username: \t\t Role: \t\t Name:");
            lstCurrentUsers.Add("ttrivet \t\t\t Admin \t\t Tyler Rivet");
            lstCurrentUsers.Add("aawallac \t\t\t User \t\t Adrienne Galbraith");
            lstCurrentUsers.Add("jefeeney \t\t\t User \t\t Jennifer Freeney");
            lstCurrentUsers.Add("awbuckst \t\t Admin \t\t Alex Buckstiegel");

            lstCurrentCategories.Add("Consumable");
            lstCurrentCategories.Add("Asset");
            lstCurrentCategories.Add("Checkout Item");
            lstCurrentCategories.Add("High Fidelity Simulator");
            lstCurrentCategories.Add("Low Fidelity Simulator");

            lstCurrentSuppliers.Add("Amazon \t\t https://www.amazon.com/");
            lstCurrentSuppliers.Add("Doctors R Us \t https://www.doctorsrus.com");
            lstCurrentSuppliers.Add("Walmart \t\t https://www.walmart.com/");
            lstCurrentSuppliers.Add("Target \t\t https://www.target.com/");





            frameSettings.Navigate(new Users(lstCurrentUsers));
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e) {
            frameSettings.Navigate(new Users(lstCurrentUsers));
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e) {
            frameSettings.Navigate(new ConfigureCategories(lstCurrentCategories));
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e) {
            frameSettings.Navigate(new ConfigureReports());
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e) {
            frameSettings.Navigate(new Suppliers(lstCurrentSuppliers));
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e) {

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            frameSettings.Navigate(new Users(lstCurrentUsers));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            frameSettings.Navigate(new Users(lstCurrentUsers));
        }
    }
}
