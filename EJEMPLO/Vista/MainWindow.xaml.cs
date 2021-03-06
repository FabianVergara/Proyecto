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

namespace Vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            wpfIngresoCliente ic = new wpfIngresoCliente();
            ic.ShowDialog();//bloquea que se salga hasta q cierre


        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
         MessageBoxResult resul=   MessageBox.Show("¿Desea salir ?", "Salir", MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (resul==MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("esta seguro que desea salir?");
            }

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)//argumento e
        {
            MessageBoxResult resul = MessageBox.Show("¿Desea salir ?", "Salir", MessageBoxButton.YesNo,
                MessageBoxImage.Question);

            if (resul == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("desea salir?");
                e.Cancel = true;//cancelo el evento lo cambio
            }
        }
    }
}
