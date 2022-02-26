using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.models;
using WpfApp1.views;

namespace WpfApp1.controllers
{
    public class RegistrarController
    {
        RegistrarProducto rp;
        public RegistrarController(RegistrarProducto rp)
        {
            this.rp = rp;
        }
        public void MainWindowMenuItemEventHandler(object sender, RoutedEventArgs e)
        {
            Button menu = (Button)sender;
            switch (menu.Name)
            {
                case "BtnGuardar":
                    save();
                    break;
                case "BtnCargar":
                    
                    break;
                case "BtnSalir":
                    Environment.Exit(0);
                    break;
            }
        }

        private void save()
        {
            
            
           // SaveFileDialog openFileDialog = new SaveFileDialog();
           
            
            //MessageBox.Show(productoFinal.ToString());
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() != null)
            {
                string nombre = rp.txtNombre.Text;
                int cantidad = Convert.ToInt32(rp.txtCantidad.Text);
                int precio = Convert.ToInt32(rp.txtPrecioUnitario.Text);
                double total = cantidad * precio;
                Producto productoFinal = new Producto(nombre, precio, cantidad, total);
                
                StreamWriter sw = new StreamWriter(sv.FileName);
                
                sw.WriteLine(productoFinal.ToString());
                sw.Close();

                //File.WriteAllText(sv.FileName,productoFinal.ToString());

                //string rutaArchivo = sv.FileName;

                //BinaryFormatter formateador = new BinaryFormatter();
                //var ruta = sv.FileName;
                //Stream miStream = new FileStream(rutaArchivo, FileMode.Open, FileAccess.Write);
                //File.WriteAllText(sv.FileName, ruta);
                //miStream.Close();
            }

        }

    }
}
