using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        private string _nombre;
        private int _precio;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }



    }
}
