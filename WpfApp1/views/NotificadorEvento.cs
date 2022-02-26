using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.views
{
    [Serializable]
    public partial class NotificadorEvento: INotifyPropertyChanged
    {

        private string nombre;
        private string apellido;
        private string nombreCompleto;

        public event PropertyChangedEventHandler ?PropertyChanged;

        public NotificadorEvento()
        {
            nombre = "";
            apellido = "";
            nombreCompleto = "";
            PropertyChanged = null;
        }

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged("NombreCompleto");
            }
            
            
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value;
            OnPropertyChanged("NombreCompleto");
        }

        
    }
        public string NombreCompleto
        {
            get
            {
                nombreCompleto = Nombre + apellido;
                int valorUno = Convert.ToInt32(Nombre);
                int valorDos = Convert.ToInt32(apellido);
                int total = valorUno + valorDos;

                return total.ToString(); 
            }
            set {  }
        }
    }
}
