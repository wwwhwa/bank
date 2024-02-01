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

namespace wpfBank.Pages
{
    /// <summary>
    /// Логика взаимодействия для Tariff.xaml
    /// </summary>
    public partial class Tariff : Page
    {
        public Tariff()
        {
            InitializeComponent();
        }

        private void btnIncome_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/Calculator.xaml", UriKind.Relative));
        }
    }
}
