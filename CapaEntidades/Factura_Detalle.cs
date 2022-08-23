using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    class Factura_Detalle
    {
        private double _subTotal;

        public double SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }
    }
}
