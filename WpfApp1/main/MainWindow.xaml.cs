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
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static string contraseña;

        private void btn_Salir(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btn_Ingresar(object sender, RoutedEventArgs e)
        {
            ValidaIngresar();
           
        }

        private void btn_Registrarse(object sender, RoutedEventArgs e)
        {
            
            ValidaRegistrar();
        }
        public void ValidaRegistrar()
        {
            string user = boxUser.Text;
            string password = boxPassword.Password;
            string archivo = user + ".txt";

            if (File.Exists(archivo))
            {

                MessageBox.Show("El Nombre de Usuario ya Existe");
                boxPassword.Password = archivo;
            }
            else
            {
                if (password.Length > 0 && password.Length < 4)
                {
                    MessageBox.Show("La contraseña no puede tener menos de 4 Caracteres");
       
                    boxPassword.Password = "";
                }
                else
                {
                    if (password.Equals("") || (user.Equals("")))
                    {
                        MessageBox.Show("No pueden haber Campos Vacios");
                    }
                    else
                    {
                        File.WriteAllText(archivo, password);
                        MessageBox.Show("Te has Registrado con Exito");
                        boxUser.Text = "";
                        boxPassword.Password = "";
                    }
                }
            }
        }
        public void ValidaIngresar()
        {
            string user = boxUser.Text;
            string password = boxPassword.Password;
            string archivo = user + ".txt";

            if (File.Exists(archivo))
            {
                contraseña = File.ReadAllText(archivo);
                if (password.Equals(contraseña))
                {
                    //MessageBox.Show("Ha Iniciado Exitosamente\nBienvenido al Programa");
                    MenuPrincipal mp = new MenuPrincipal();
                    mp.Show();
                    Close();
                }
                else
                {
                    if (password.Equals(""))
                    {
                        MessageBox.Show("El campo de contraseña esta vacio");
                    }
                    else
                    {
                        MessageBox.Show("La contraseña es incorrecta");
                        boxPassword.Password = "";
                    }
                }
            }
            else
            {
                if (user.Equals("") && password.Equals(""))
                {
                    MessageBox.Show("Ambos campos estan vacios");
                }
                else
                {
                    if (user.Equals(""))
                    {
                        MessageBox.Show("El campo de usuario esta vacio");
                    }
                    else
                    {
                        MessageBox.Show("El nombre de usuario no existe");
                        //boxUser.Text = "";
                        boxPassword.Password = "";
                    }
                }
            }
        }
    }

}
