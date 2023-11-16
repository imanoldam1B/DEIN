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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConexionBD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection miConexionSql;
        public MainWindow()
        {
            InitializeComponent();
            string miConexion = ConfigurationManager.ConnectionStrings["ConexionBD.Properties.Settings.GestorEmpleadoConnectionString"].ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
            miConexionSql.Open();
            MostrarUsuarios();
        }
        private void MostrarUsuarios()
        {
            string consulta = "SELECT * FROM Usuarios";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, miConexionSql);
            DataTable usuarios = new DataTable();

            adapter.Fill(usuarios);

            dataGridArticulos.ItemsSource = usuarios.DefaultView;
        }
    }
}
