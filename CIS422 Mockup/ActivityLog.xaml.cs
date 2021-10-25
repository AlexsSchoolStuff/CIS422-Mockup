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
    /// Interaction logic for ActivityLog.xaml
    /// </summary>
    public partial class ActivityLog : Page {
        public ActivityLog() {
            InitializeComponent();
        }
        public ActivityLog(List<String> lstActivity) {
            InitializeComponent();
            foreach(String item in lstActivity) {
                lstActivityLog.Items.Add(item);
            }
        }
    }
}
