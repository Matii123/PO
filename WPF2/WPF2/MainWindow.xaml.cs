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

namespace WPF2
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtDodawanie_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(TbDane.Text);
            int b = int.Parse(TbDane2.Text);
            int suma = a + b;
            TbWynik.Text = suma.ToString();
        }

        private void BtOdejmowanie_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(TbDane.Text);
            int b = int.Parse(TbDane2.Text);
            int odejmowanie = a - b;
            TbWynik.Text = odejmowanie.ToString();
        }

        private void BtMnozenie_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(TbDane.Text);
            int b = int.Parse(TbDane2.Text);
            int mnozenie = a * b;
            TbWynik.Text = mnozenie.ToString();
        }

        private void BtDzielenie_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(TbDane.Text);
            int b = int.Parse(TbDane2.Text);
            int dzielenie = a / b;
            TbWynik.Text = dzielenie.ToString();
        }
    }
}
