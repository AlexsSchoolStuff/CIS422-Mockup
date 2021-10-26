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
    /// Interaction logic for Users.xaml
    /// </summary>
    public partial class Users : Page {
        public Users() {
            InitializeComponent();
        }
        public Users(List<String> lstCurrentUsers) {
            InitializeComponent();
            foreach(String item in lstCurrentUsers) {
                lstUsers.Items.Add(item);
            }
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("User");
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            txtUserName.Text = "awbuckst";
            cmbRole.SelectedIndex = 0;
            txtName.Text = "Alex Buckstiegel";
            txtUserName.Visibility = Visibility.Visible;
            cmbRole.Visibility = Visibility.Visible;
            txtName.Visibility = Visibility.Visible;
            lblUserName.Visibility = Visibility.Visible;
            lblRole.Visibility = Visibility.Visible;
            lblName.Visibility = Visibility.Visible;
        }
    }
}
