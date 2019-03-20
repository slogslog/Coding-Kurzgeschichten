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

namespace Umrechner_Celsius_auf_Kelvin
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Celsius.Text = "0";
            Kelvin.Text = "273,15";
        }

        private void OnConvertToKelvin(object sender, RoutedEventArgs e)
        {
            if ( double.TryParse(Celsius.Text, out double celsius ))
            {
                Kelvin.Text = (celsius + 273.15).ToString();
            }
        }

        private void OnConvertToCelsius(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(Kelvin.Text, out double kelvin))
            {
                Celsius.Text = (kelvin - 273.15).ToString();
            }
        }
    }
}
