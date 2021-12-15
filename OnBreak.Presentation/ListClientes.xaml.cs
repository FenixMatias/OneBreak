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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;

namespace OnBreak.Presentation
{
    /// <summary>
    /// Lógica de interacción para ListClientes.xaml
    /// </summary>
    public partial class ListClientes : MetroWindow
    { 
        public ListClientes()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }

        private void Btnvolver_Click(object sender, RoutedEventArgs e)
        {
            AdmiClientes admiclientes = new AdmiClientes();
            admiclientes.Show();
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
