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
    /// Interaction logic for ConfigureCategories.xaml
    /// </summary>
    public partial class ConfigureCategories : Page {
        public ConfigureCategories() {
            InitializeComponent();
        }
        public ConfigureCategories(List<String> lstConfigureCategories) {
            InitializeComponent();
            foreach(String item in lstConfigureCategories) {
                lstCategories.Items.Add(item);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            txtEdit.Visibility = Visibility.Hidden;

            txtAdd.Visibility = Visibility.Visible;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            txtAdd.Visibility = Visibility.Hidden;
            txtEdit.Visibility = Visibility.Visible;
        }
    }
}
