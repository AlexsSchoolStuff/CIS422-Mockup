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
    /// Interaction logic for Simulator_Uses.xaml
    /// </summary>
    public partial class Simulator_Uses : Page {
        public Simulator_Uses() {
            InitializeComponent();
        }
        public Simulator_Uses(List<String> lstSimUses) {
            foreach (String item in lstSimUses) {
                InitializeComponent();
                lstSimulatorUses.Items.Add(item);
            }
        }
    }
}
