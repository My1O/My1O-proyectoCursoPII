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

namespace WpfApp1.views
{
    /// <summary>
    /// Interaction logic for MenuPrincipal.xaml
    /// </summary>
    public partial class MenuPrincipal : Window
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        private void Accion1_Click(object sender, RoutedEventArgs e)
        {
            RegistrarProducto registro = new RegistrarProducto();
            registro.Show();
        }

        private void AccionVerProducto(object sender, RoutedEventArgs e)
        {
            MostrarProductos mostrarProductos = new MostrarProductos();
            mostrarProductos.Show();
        }
    }
}
