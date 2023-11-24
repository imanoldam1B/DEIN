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

namespace Estilos_de_Imanol
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
        private void Boton_WOD(object sender, RoutedEventArgs e)
        {
            WOD wod = new WOD();
            this.Close();
            wod.Show();
        }
        private void Boton_Reservar(object sender, RoutedEventArgs e)
        {
            MapaReserva mapa = new MapaReserva();
            this.Close();
            mapa.Show();
        }
        private void Boton_Publicar(object sender, RoutedEventArgs e)
        {
            Videos videos = new Videos();
            this.Close();
            videos.Show();
        }
    }
}
