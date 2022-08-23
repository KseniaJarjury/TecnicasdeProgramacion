using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Empleado:Usuario
    {

        private string _nombre;
        private string _apellido;
        private string _dni;
        private string _domicilio;
        private string _puesto;
        private int _legajo;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }


        public string Puesto
        {
            get { return _puesto; }
            set { _puesto = value; }
        }


        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }


        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }


    }
}
