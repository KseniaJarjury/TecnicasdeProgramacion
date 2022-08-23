using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_CapaDato;

namespace BLL_CapaNegocio
{
    public class Cliente
    {
        Cliente dbUsuario = new Cliente();

        public bool altaCliente (string nombre, string apellido, string dni, string dom, string CP, string email, DateTime fNac, string tel, string nomUsua, string contra, string contraRep)
        {
            try
            {
                bool resultado;

                resultado = dbUsuario.altaCliente(nombre, apellido, dni, dom, CP, email, fNac, tel, nomUsua, contra, contraRep);

                return resultado;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
