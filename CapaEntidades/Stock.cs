using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public  class Stock
    {
        private int _cantidad;
        private string _categoria;
        private List<Detalle_de_Stock> _detalleStock;

        public int Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public List<Detalle_de_Stock> DetalleStock
        {
            get { return _detalleStock; }
            set { _detalleStock = value; }
        }


    }
}
