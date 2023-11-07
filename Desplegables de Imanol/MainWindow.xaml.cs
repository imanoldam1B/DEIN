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

namespace Desplegables_de_Imanol
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
        private void M_Nuevo_CLick (object sender, RoutedEventArgs e)
        {
            MainWindow NuevaVentana = new MainWindow();
            NuevaVentana.Show();
        }
        private void M_Abrir_CLick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog abrirFichero = new Microsoft.Win32.OpenFileDialog();
            abrirFichero.ShowDialog();
        }
        private void M_Guardar_CLick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Guardado ");
        }
        private void M_Guardar_Como_CLick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog guardarFicheroComo = new Microsoft.Win32.SaveFileDialog();
            guardarFicheroComo.ShowDialog();
        }
        private void M_Imprimir_CLick(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog Imprimir = new System.Windows.Controls.PrintDialog();
            Imprimir.ShowDialog();
        }
        private void M_Salir_CLick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void M_Usuarios_CLick(object sender, RoutedEventArgs e)
        {
            Usuarios AbrirUsuarios = new Usuarios();
            AbrirUsuarios.Show();
        }
        private void M_Copiar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Copiado");
        }
        private void MCortar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Cortado ");
        }
        private void M_Pegar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Pegado ");
        }
        private void M_Eliminar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" Eliminado ");
        }
    }
}
