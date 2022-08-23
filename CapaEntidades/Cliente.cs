using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente :Usuario
    {
        private string _nombre;
        private string _apellido;
        private long _dni;
        private int _telefono;
        private string _domicilio;
        private DateTime _fechadenacimiento;
        private string _email;
        private int _codpostal;

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

        public long DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public int Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }

        public int CodPostal
        {
            get { return _codpostal; }
            set { _codpostal = value; }
        }

        public DateTime FechaDeNacimiento
        {
            get { return _fechadenacimiento; }
            set { _fechadenacimiento = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
