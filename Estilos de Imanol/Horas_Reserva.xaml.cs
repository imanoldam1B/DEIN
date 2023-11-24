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

namespace Estilos_de_Imanol
{
    /// <summary>
    /// Lógica de interacción para Horas_Reserva.xaml
    /// </summary>
    public partial class Horas_Reserva : Window
    {
        public Horas_Reserva()
        {
            InitializeComponent();
        }
        private void Boton_MenuPrincipal(object sender, RoutedEventArgs e)
        {
            MainWindow menuPrincipal = new MainWindow();
            this.Close();
            menuPrincipal.Show();
        }
        private void Boton_Contacto(object sender, RoutedEventArgs e)
        {
            Contacto_Sugerencias contacto = new Contacto_Sugerencias();
            this.Close();
            contacto.Show();
        }
        private void Boton_Cuenta(object sender, RoutedEventArgs e)
        {
            micuenta cuenta = new micuenta();
            this.Close();
            cuenta.Show();
        }
        private void Boton_EscogerHora(object sender, RoutedEventArgs e)
        {
            MapaReserva mp = new MapaReserva();
            this.Close();
            mp.Show();
        }
    }
}
