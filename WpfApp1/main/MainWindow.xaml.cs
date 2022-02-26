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
using System.IO;
using WpfApp1.views;
using WpfApp1.controllers;

namespace WpfApp1.main
{
    /// <summary>
    /// Proyecto de Programacion II - Justhin Gadea - Camilo Castro
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetUpController();
        }
        private void SetUpController()
        {
            LoginController lc = new LoginController(this);
            RoutedEventHandler routed = new RoutedEventHandler(lc.MainWindowMenuItemEventHandler);
            this.btn_Ingresar.Click += routed;
            this.btn_Salir.Click += routed;
            this.btn_Registrarse.Click += routed;
        }
    }

}
