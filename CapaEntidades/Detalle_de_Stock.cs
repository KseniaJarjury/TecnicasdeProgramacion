using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Detalle_de_Stock
    {

        private string _producto;
        private int _cantidad;

        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }
    }
}
