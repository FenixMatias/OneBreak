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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace OnBreak.Presentation
{
    /// <summary>
    /// Lógica de interacción para AdmiContrato.xaml
    /// </summary>
    public partial class AdmiContrato : MetroWindow
    {
        public AdmiContrato()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Btnvolver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwindow = new MainWindow();
            mainwindow.Show();
            Close();
        }

        private void Btnlistacontra_Click(object sender, RoutedEventArgs e)
        {
            ListContratos listcontratos = new ListContratos();
            listcontratos.Show();
            Close();
        }

        private async void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtalert.Text.Trim() != "")
            {
                await this.ShowMessageAsync("Informacion", txtalert.Text);
            }
        }
    }
}