using MB_Diagnostics_App.Models;
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
using System.Windows.Shapes;

namespace MB_Diagnostics_App.Views.Windows
{
    /// <summary>
    /// Interaction logic for MultimetrWindow.xaml
    /// </summary>
    public partial class MultimetrWindow : Window
    {
        PointsDataBase db1;
        public MultimetrWindow()
        {
            InitializeComponent();
            db1 = new PointsDataBase();
            foreach (string e in db1.GetPointList())
                {
                minuscontact.Items.Add(e);
                pluscontact.Items.Add(e);
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mainTB.Text = db1.GetMeasurements(new Pair(pluscontact.Text, minuscontact.Text));
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mainTB.Text = db1.GetMeasurements(db1.p1);
        }
    }
}
