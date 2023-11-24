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

namespace Estilos_de_Imanol
{
    /// <summary>
    /// Lógica de interacción para MapaReserva.xaml
    /// </summary>
    public partial class MapaReserva : Window
    {
        public MapaReserva()
        {
            InitializeComponent();
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
        private void Boton_RM(object sender, RoutedEventArgs e)
        {
            RM rm = new RM();
            this.Close();
            rm.Show();
        }
        private void reservar (object sender, RoutedEventArgs e)
        {
            MainWindow mainwnd = new MainWindow();
            this.Close();
            mainwnd.Show();
        }
    }
}
