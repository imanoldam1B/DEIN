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

namespace Navegación_de_Imanol
{
    /// <summary>
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }
        private void MainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow abrirMainWindow = new MainWindow();
            this.Close();
            abrirMainWindow.Show();

        }
        private void Botón2_AbrirPágina(object sender, RoutedEventArgs e)
        {
            MyFrame.NavigationService.Navigate(new Page1());
        }
    }
}
