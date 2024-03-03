using Microsoft.Win32;
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

namespace Formulario_NoUsable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool modoOscuro = false;
        private string textoPrevio = string.Empty;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void DatePickerButton_Click(object sender, RoutedEventArgs e)
        {
            miDatePicker.Visibility = Visibility.Visible;
            miDatePicker.Focus();
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

        private void ModoOscuro(object sender, RoutedEventArgs e)
        {
            modoOscuro = !modoOscuro;
            if (modoOscuro)
            {
                // Modo oscuro
                SolidColorBrush darkBackground = new SolidColorBrush(Colors.Black);
                SolidColorBrush darkForeground = new SolidColorBrush(Colors.White);

                this.Background = darkBackground;
                this.Foreground = darkForeground;
                btnAdjuntarFotografia.Background = darkBackground;
                btnAdjuntarFotografia.Foreground = darkForeground;
            }
            else
            {
                // Modo claro (restaurar colores originales)
                SolidColorBrush lightBackground = new SolidColorBrush(Colors.White);
                SolidColorBrush lightForeground = new SolidColorBrush(Colors.Black);

                this.Background = lightBackground;
                this.Foreground = lightForeground;
                btnAdjuntarFotografia.Background = lightBackground;
                btnAdjuntarFotografia.Foreground = lightForeground;
            }
        }

        private void TxtDescripcionPuesto_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Agregar salto de línea si hay texto previo
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text += "\n";
            }

            // Generar y agregar texto aleatorio
            textBox.Text += GenerarTextoAleatorio(1000);
            textBox.CaretIndex = textBox.Text.Length; // Colocar el cursor al final del texto

            textoPrevio = textBox.Text;
        }
        private void TxtDescripcionPuesto_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            textoPrevio = textBox.Text;
        }

        private string GenerarTextoAleatorio(int longitud)
        {
            Random random = new Random();
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < longitud; i++)
            {
                int indice = random.Next(caracteres.Length);
                sb.Append(caracteres[indice]);
            }

            return sb.ToString();
        }


        private void Txt_GotFocus(Object sender, RoutedEventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == "Dirección" || textBox.Text == "Ciudad" || textBox.Text == "Provincia" || textBox.Text == "Código Postal" || textBox.Text == "País")
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

            if (datosObligatoriosLlenos())
            {
                if (telefono.Length > 12)
                {
                    if (nombre == nombre.ToUpper())
                    {
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
                        MessageBox.Show("El nombre debe estar escrito en mayúsculas.");
                    }
                }
                else
                {
                    MessageBox.Show("El número de teléfono debe tener más caracteres.");
                }
                
            }
            else
            {
                MessageBox.Show("Faltan campos obligatorios por rellenar");
            }

        }

        private bool datosObligatoriosLlenos()
        {
            if (!(string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtTelefono.Text)))
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
