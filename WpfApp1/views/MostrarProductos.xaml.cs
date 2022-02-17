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
    /// Interaction logic for MostrarProductos.xaml
    /// </summary>
    public partial class MostrarProductos : Window
    {
        public MostrarProductos()
        {
            InitializeComponent();
            JuntaNombre = new NotificadorEvento { Nombre="0", Apellido = "0" };
            this.DataContext = JuntaNombre;
        }
        public NotificadorEvento JuntaNombre;
    }
}
