using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessData.Models
{
    public class Pizza : INotifyPropertyChanged
    {
        [PrimaryKey, AutoIncrement]
     
        public int Id
        {
            get;
            set;
        }
        String nombre;
        public String Nombre
        {
            get {
                return nombre;
            }
            set
            {
                nombre = value;
                 
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Nombre"));
        
        } }

        int precio;
        public int Precio { get {
            return precio;
        }
            set {
                precio = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Precio"));
            }
        }

        int tamanio;
        public int Tamanio { get {
            return tamanio;
        }
            set {
                tamanio = value;
                 
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("Tamanio"));
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;
    }
}
