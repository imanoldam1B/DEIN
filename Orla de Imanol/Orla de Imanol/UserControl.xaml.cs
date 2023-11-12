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
    /// Lógica de interacción para UserControl.xaml
    /// </summary>
    public partial class UserControl : UserControl
    {
        public static DependencyProperty NombreProperty = DependencyProperty.Register("Nombre", typeof(string), typeof(Puesto), new PropertyMetadata(string.Empty));
        public static DependencyProperty ApellidosProperty = DependencyProperty.Register("Apellidos", typeof(string), typeof(Puesto), new PropertyMetadata(string.Empty));
        public static DependencyProperty EmailProperty = DependencyProperty.Register("Email", typeof(string), typeof(Puesto), new PropertyMetadata(string.Empty));
        public static DependencyProperty FotoPropoerty = DependencyProperty.Register("Apellidos", typeof(Image), typeof(Puesto), new PropertyMetadata(string.Empty));
        public string Nombre
        {
            get { return (string)GetValue(NombreProperty); }
            set { SetValue(NombreProperty, value); }
        }
        public string Apellidos
        {
            get { return (string)GetValue(ApellidosProperty); }
            set { SetValue(ApellidosProperty, value); }
        }
        public UserControl()
        {
            InitializeComponent();
        }
        private void Persona_MouseEnter(object sender, MouseEventArgs e)
        {
            LabelPuesto.Text = Nombre + " " + Apellidos;
        }
        private void Persona_MouseLeave(object sender, MouseEventArgs e)
        {
            LabelPuesto.Text = "";
        }
        private void Persona_Click(object sender, RoutedEventArgs e)
        {
            LabelPuesto.Text = Email;
        }
        private void Persona_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Profile win2 = new Profile(Nombre, Apellidos, Email, Foto);
            win2.Show();
        }
    }
}
