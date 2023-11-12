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

namespace Orla_de_Imanol
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
        private void MouseEnter41(object sender, MouseEventArgs e)
        {
            LabelPuesto41.Text = "Aritz Delegado";
        }

        private void MouseLeave41(object sender,

        MouseEventArgs e)
        {
            LabelPuesto41.Text = "";
        }
        private void MouseClick41(object sender, RoutedEventArgs e)
        {
            LabelPuesto41.Text = "delegado_estrella@educacion.navarra.es";
        }
        private void Persona41_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Profile win2 = new Profile("Nombre", "Apellidos", "email_alumno@educacion.navarra.es", "Imagenes/AritzP.jpg");

            win2.Show();
        }
    }
}
