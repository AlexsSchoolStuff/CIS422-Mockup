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
    /// Interaction logic for ViewInventory.xaml
    /// </summary>
    public partial class ViewInventory : Page {
        public ViewInventory() {
            InitializeComponent();
        }
        public ViewInventory(List<String> inventory) {
            InitializeComponent();
            foreach(String item in inventory) {
                lstViewItems.Items.Add(item);
            }

        }

    }
}
