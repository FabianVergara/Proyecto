using Biblioteca.Entidades;
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


namespace Vista
{
    /// <summary>
    /// Lógica de interacción para wpfIngresoCliente.xaml
    /// </summary>
    public partial class wpfIngresoCliente : Window
    {
        public wpfIngresoCliente()
        {
            InitializeComponent();
            cbo_ECivil.Items.Add( "Seleccione estado");
            cbo_ECivil.SelectedIndex = 0;
            cbo_sexo.Items.Add("Seleccione sexo"); 
            cbo_sexo.SelectedIndex = 0;
        }

        private void btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
              
                Cliente cli = new Cliente();
                cli.RutCliente = txt_rut.Text;
                cli.Nombres = txt_nombres.Text;
                cli.Apellidos = txt_apellidos.Text;
                cli.FechaNaci = (DateTime)dpkFechaN.SelectedDate;          
                cli.IdEstadoCivil = cbo_ECivil.SelectedIndex;               
                cli.IdSexo = cbo_sexo.SelectedIndex;
                cli.Grabar();

              
           
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void txt_rut_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Volver_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventana = new Vista.MainWindow();
            ventana.Show();
            this.Close();
        }
    }
}
