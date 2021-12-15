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
using MahApps.Metro.Controls;

namespace OnBreak.Presentation
{ 
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void BtnAdmicli_Click(object sender, RoutedEventArgs e)
        {
            AdmiClientes admiclientes = new AdmiClientes();
            admiclientes.Show();
            Close();
        }
        

        private void Btnlistclientes_Click(object sender, RoutedEventArgs e)
        {
            ListClientes listclientes = new ListClientes();
            listclientes.Show();
            Close();
        }

        private void BtnAdmicCont_Click(object sender, RoutedEventArgs e)
        {
            AdmiContrato admicontract = new AdmiContrato();
            admicontract.Show();
            Close();
        }

        private void Btnlistcontratos_Click(object sender, RoutedEventArgs e)
        {
            ListContratos listcontratos = new ListContratos();
            listcontratos.Show();
            Close();
        }
    }
}
