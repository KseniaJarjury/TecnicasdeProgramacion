using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Detalle_Orden_Compra
    {
        private int _cantidad;
        private string _producto;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public string Producto
        {
            get { return _producto; }
            set { _producto = value; }
        }
    }
}
