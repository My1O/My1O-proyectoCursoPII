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
using WpfApp1.controllers;

namespace WpfApp1.views
{
    /// <summary>
    /// Interaction logic for RegistrarProducto.xaml
    /// </summary>
    public partial class RegistrarProducto : Window
    {
        public RegistrarProducto()
        {
            InitializeComponent();
            SetUpController();
        }

        private void SetUpController()
        {
            RegistrarController rc = new RegistrarController(this);
            RoutedEventHandler routed = new RoutedEventHandler(rc.MainWindowMenuItemEventHandler);
            this.BtnGuardar.Click += routed;
            this.BtnCargar.Click += routed;
            this.BtnSalir.Click += routed;
        }
    }
}
