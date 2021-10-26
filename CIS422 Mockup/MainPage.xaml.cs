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
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page {
        public MainPage() {
            InitializeComponent();

        }
        public MainPage(List<String> recentItems, List<String> lowStock, List<String> dynamicItems) {
            InitializeComponent();
            PopulateListBoxs(recentItems, lowStock, dynamicItems);
        }

        public void PopulateListBoxs(List<String> recentItems, List<String> lowStock, List<String> dynamicItems) {
            foreach(String item in recentItems) {
                lstRecentItems.Items.Add(item);
            }
            foreach (String item in lowStock) {
                lstLowStock.Items.Add(item);
            }
            foreach(String item in dynamicItems) {
                lstDynamicItems.Items.Add(item);
            }
            lstRecentItems.SelectedIndex = 0;
            lstLowStock.SelectedIndex = 0;
            lstDynamicItems.SelectedIndex = 0;

        }
    }
}
