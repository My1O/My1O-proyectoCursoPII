using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.models
{
    [Serializable]
    public  class Producto
    {
        //string fecha;
        private string NombreProducto;
        private double PrecioUnitario;
        private int Cantidad ;
        private double Total;

        public Producto()
        { 
            
        }
        public Producto(string nombreProducto, double PrecioUnitario, int cantidad, double total)
        {
            this.NombreProducto = nombreProducto;
            this.PrecioUnitario = PrecioUnitario;
            this.Cantidad1 = cantidad;
            this.Total1 = total;
        }
        
        public string NombreProducto1 { get => NombreProducto; set => NombreProducto = value; }
        public double PrecioUnitario1 { get => PrecioUnitario; set => PrecioUnitario = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public double Total1 { get => Total; set => Total = value; }

        public double PrecioTotal(double PrecioUnitario, int Cantidad)
        {
            double total = PrecioUnitario * Cantidad;
            return total;
        }
    }
}