using MB_Diagnostics_App.Models;
using MB_Diagnostics_App.Models.Scenarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

namespace MB_Diagnostics_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Scenario sc;
        string[] deffects = { "Поломка BIOS", "Поломка ОЗУ", "Перегорела 5V", "Перегорела 12V", "Разрядилась батарейка", "RTC не исправен", "Ю.М. не исправен", "Видеочип/видеоразъем не исправен"};
        int deffectindex = -1;

        public MainWindow()
        {
            sc = new Scenario();
            InitializeComponent();
            maincombo.Items.Add(deffects[0]);
            maincombo.Items.Add(deffects[1]);
            maincombo.Items.Add(deffects[2]);
            maincombo.Items.Add(deffects[3]);
            maincombo.Items.Add(deffects[4]);
            maincombo.Items.Add(deffects[5]);
            maincombo.Items.Add(deffects[6]);
            maincombo.Items.Add(deffects[7]);
            sc.SetName(deffects[0]);
            sc.SetStartStatement("Не стартует");
            sc.SetBiosStatement("Осцилограф не показывает активность");
            deffectindex = 0;
        }

        /*private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Это сообщение!", "Заголовок", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MB_Diagnostics_App.Views.Windows.MultimetrWindow window = new MB_Diagnostics_App.Views.Windows.MultimetrWindow();
            window.Show();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MB_Diagnostics_App.Views.Windows.MB_layout window = new Views.Windows.MB_layout();
            window.Show();
        }

        private void CheckBox_Checked()
        {
*/
        
      

        private void defect1_Click(object sender, RoutedEventArgs e)
        {
            sc = new Scenario();
            MessageBox.Show("Неисправность 1 загружена", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            sc.SetName(deffects[0]);
            sc.SetStartStatement("Не стартует");
            sc.SetBiosStatement("Осцилограф не показывает активность");
            deffectindex = 0;
        }

        private void defect2_Click(object sender, RoutedEventArgs e)
        {
            sc = new Scenario();
            MessageBox.Show("Неисправность 2 загружена", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            sc.SetName(deffects[1]);
            sc.SetStartStatement("Стартует но 4 короткими писками из спикера. Изображения нет");
            sc.SetRAMStatement("MemtestFailed");
            deffectindex = 1;
        }

        private void defect3_Click(object sender, RoutedEventArgs e)
        {
            sc = new Scenario();
            MessageBox.Show("Неисправность 3 загружена", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            sc.SetName(deffects[2]);
            sc.SetStartStatement("Не стартует");
            sc.SetBiosStatement("Осцилограф не показывает активность");
            sc.Set5VStatement("0V");
            deffectindex = 2;
        }

        private void defect4_Click(object sender, RoutedEventArgs e)
        {
            sc = new Scenario();
            MessageBox.Show("Неисправность 4 загружена", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            sc.SetName(deffects[3]);
            sc.SetStartStatement("Не стартует");
            //sc.SetBiosStatement("Осцилограф не показывает активность");
            sc.Set12VStatement("0V");
            deffectindex = 3;
        }

        private void defect5_Click(object sender, RoutedEventArgs e)
        {
            sc = new Scenario();
            MessageBox.Show("Неисправность 5 загружена", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            sc.SetName(deffects[4]);
            sc.SetStartStatement("Стартует, но появляется ошибка Date and Time Not Set");
            deffectindex = 4;
        }

        private void defect6_Click(object sender, RoutedEventArgs e)
        {
            sc = new Scenario();
            MessageBox.Show("Неисправность 6 загружена", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            sc.SetName(deffects[5]);
            sc.SetStartStatement("Не стартует");
            deffectindex = 5;
        }

        private void defect7_Click(object sender, RoutedEventArgs e)
        {
            sc = new Scenario();
            MessageBox.Show("Неисправность 7 загружена", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            sc.SetName(deffects[6]);
            sc.SetStartStatement("Не стартует");
            sc.SetUSBStatement("4.8123V");
            deffectindex = 6;

        }

        private void defect8_Click(object sender, RoutedEventArgs e)
        {
            sc = new Scenario();
            MessageBox.Show("Неисправность 8 загружена", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            sc.SetName(deffects[7]);
            sc.SetStartStatement("Стартует, но нет изображения");
            deffectindex = 7;
        }

        private void BIOS_but_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sc.scenario["bios"], "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void RAM_but_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sc.scenario["RAM"], "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void fiveV_but_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sc.scenario["5V"], "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void twentyV_but_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sc.scenario["12V"], "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void battery_but_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sc.scenario["battery"], "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void RTC_but_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sc.scenario["RTC"], "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void USB_but_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sc.scenario["USB"], "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        private void Start_but_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sc.scenario["Start"], "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            if (maincombo.Text == deffects[deffectindex])
            {
                switch (deffectindex)
                {
                    case 0:
                        defect1.IsEnabled = false;
                        
                        defect1.Content = deffects[deffectindex];
                        defect1.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 1:
                        defect2.IsEnabled = false;
                        defect2.Background = new SolidColorBrush(Colors.Red);
                        defect2.Content = deffects[deffectindex];
                        break;
                    case 2:
                        // Код для выполнения, если expression равно constant2
                        defect3.IsEnabled = false;
                        defect3.Background = new SolidColorBrush(Colors.Red);
                        defect3.Content = deffects[deffectindex];
                        break;
                    case 3:
                        // Код для выполнения, если expression равно constant2
                        defect4.IsEnabled = false;
                        defect4.Background = new SolidColorBrush(Colors.Red);
                        defect4.Content = deffects[deffectindex];
                        break;
                    case 4:
                        // Код для выполнения, если expression равно constant2
                        defect5.IsEnabled = false;
                        defect5.Background = new SolidColorBrush(Colors.Red);
                        defect5.Content = deffects[deffectindex];

                        break;
                    case 5:
                        // Код для выполнения, если expression равно constant2
                        defect6.IsEnabled = false;
                        defect6.Background = new SolidColorBrush(Colors.Red);

                        defect6.Content = deffects[deffectindex];
                        break;
                    case 6:
                        // Код для выполнения, если expression равно constant2
                        defect7.IsEnabled = false;
                        defect7.Background = new SolidColorBrush(Colors.Red);
                        defect7.Content = deffects[deffectindex];
                        break;
                    case 7:
                        // Код для выполнения, если expression равно constant2
                        defect8.IsEnabled = false;
                        defect8.Background = new SolidColorBrush(Colors.Red);
                        defect8.Content = deffects[deffectindex];
                        break;

                    // Дополнительные case
                    default:
                        // Код для выполнения, если expression не соответствует ни одному case
                        break;
                }
                MessageBox.Show("Поломка была определена верно", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Поломка была определена неверно", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
