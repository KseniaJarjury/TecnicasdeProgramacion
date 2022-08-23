using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Factura
    {
        private int _numeroDeFactura;
        private string _formaDePago;
        private double _precioTotal;
        
        public int NumeroDeFactura
        {
            get { return _numeroDeFactura; }
            set { _numeroDeFactura = value; }
        }

        public string FormaDePago
        {
            get { return _formaDePago; }
            set { _formaDePago = value; }
        }

        public double PrecioTotal
        {
            get { return _precioTotal; }
            set { _precioTotal = value; }
        }
    }
}
