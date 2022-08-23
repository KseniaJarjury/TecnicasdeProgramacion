using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class Empresa
    {

        private int _cuit;
        private string _domicilio;
        private string _razonsocial;
        private int _codpostal;

        public int Cuit
        {
            get { return _cuit; }
            set { _cuit = value; }
        }

        public string RazonSocial
        {
            get { return _razonsocial; }
            set { _razonsocial = value; }
        }

        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }

        public int Codpostal
        {
            get { return _codpostal; }
            set { _codpostal = value; }
        }
    }
}
