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
using Microsoft.Win32;

namespace Introducción_de_Datos_de_Empleados
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

        private void OpenImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif";

            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;

                BitmapImage bitmapImage = new BitmapImage(new Uri(filePath));
                imageControl.Source = bitmapImage; 
            }
        }

        private void Txt_GotFocus(Object sender, RoutedEventArgs e)
        {
            if(sender is TextBox textBox)
            {
                if(textBox.Text == "Dirección" || textBox.Text == "Ciudad" || textBox.Text == "Provincia" || textBox.Text == "Código Postal" || textBox.Text == "País")
                {
                    textBox.Text = "";
                }
            }
        }

        private void Txt_LostFocus(object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (String.IsNullOrWhiteSpace(textBox.Text))
                {
                    if (textBox.Name == "txtDireccion")
                        textBox.Text = "Dirección";
                    else if (textBox.Name == "txtCiudad")
                        textBox.Text = "Ciudad";
                    else if (textBox.Name == "txtProvincia")
                        textBox.Text = "Provincia";
                    else if (textBox.Name == "txtCodigoPostal")
                        textBox.Text = "Código Postal";
                    else if (textBox.Name == "txtPais")
                        textBox.Text = "País";
                }
            }
        }
        private void Guardar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellidos = txtApellidos.Text;
            string email = txtEmail.Text;
            string telefono = txtTelefono.Text;

            if (datosObligatoriosLlenos()){

                var persona = new { Nombre = nombre, Apellidos = apellidos, Email = email, Telefono = telefono };

                dataGrid.Items.Add(persona);

                dataGrid.Items.Refresh();

                txtNombre.Clear();
                txtApellidos.Clear();
                txtEmail.Clear();
                txtTelefono.Clear();
            }
            else
            {
                MessageBox.Show("Faltan campos obligatorios por rellenar");
            }
            
        }

        private bool datosObligatoriosLlenos()
        {
            if (!(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text)))
            {
                return true;
            }
            return false;
        }

        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow ventanaNueva = new MainWindow();
            ventanaNueva.Show();
            this.Close();
        }
    }
}
