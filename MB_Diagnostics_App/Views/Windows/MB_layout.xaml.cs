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
using System.Windows.Shapes;

namespace MB_Diagnostics_App.Views.Windows
{
    /// <summary>
    /// Interaction logic for MB_layout.xaml
    /// </summary>
    public partial class MB_layout : Window
    {
        public MB_layout()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MB_Diagnostics_App.Views.Windows.MB_layout_windows.USB_layout window = new MB_Diagnostics_App.Views.Windows.MB_layout_windows.USB_layout();
            window.Show();
        }
    }
}
