using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.main;
using WpfApp1.views;

namespace WpfApp1.controllers
{
    public class LoginController
    {
        MainWindow mw;
        public LoginController(MainWindow mw)
        {
            this.mw = mw;
        }
        public void MainWindowMenuItemEventHandler(object sender, RoutedEventArgs e)
        {
            Button menu = (Button)sender;
            switch (menu.Name)
            {
                case "btn_Registrarse":
                    validaRegistrar();
                    break;
                case "btn_Ingresar":
                    ValidaIngresar();
                    break;
                case "btn_Salir":
                    Environment.Exit(0);
                    break;
            }
        }

        static string credencial;
        private void ValidaIngresar()
        {
            string user = mw.boxUser.Text;
            string password = mw.boxPassword.Password;
            string archivo = user + ".txt";
            

            if (File.Exists(archivo))
            {
                credencial = File.ReadAllText(archivo);
                if (password.Equals(credencial))
                {
                    //MessageBox.Show("Ha Iniciado Exitosamente\nBienvenido al Programa");
                    MenuPrincipal mp = new MenuPrincipal();
                    mp.Show();
                    
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
                        mw.boxPassword.Password = "";
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
                        mw.boxPassword.Password = "";
                    }
                }
            }
        }
        private void validaRegistrar()
        {
            string user = mw.boxUser.Text;
            string password = mw.boxPassword.Password;
            string archivo = user + ".txt";

            if (File.Exists(archivo))
            {

                MessageBox.Show("El Nombre de Usuario ya Existe");
                mw.boxPassword.Password = archivo;
            }
            else
            {
                if (password.Length > 0 && password.Length < 4)
                {
                    MessageBox.Show("La contraseña no puede tener menos de 4 Caracteres");

                    mw.boxPassword.Password = "";
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
                        mw.boxUser.Text = "";
                        mw.boxPassword.Password = "";
                    }
                }
            }
        }
    }
}
