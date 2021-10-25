﻿using System;
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
    /// Interaction logic for LowStock.xaml
    /// </summary>
    public partial class LowStock : Page {
        public LowStock() {
            InitializeComponent();
        }
        public LowStock(List<String> lstLow) {
            InitializeComponent();
            foreach(String item in lstLow) {
                lstLowStock.Items.Add(item);
            }
        }
    }
}