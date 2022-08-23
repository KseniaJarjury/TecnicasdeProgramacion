using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_CapaDato;

namespace BLL_CapaNegocio
{
    public class Administrador : Empleado
    {
        Administrador dbEmpleado = new Administrador();
        public bool altaEmpleado(string nombre, string apellido, string dni, string dom, string puesto, string cuit, string nomUsua, string contra, string contraRep)
        {
            try
            {
                bool resultado;

                resultado = dbEmpleado.altaEmpleado(nombre, apellido, dni, dom, puesto, cuit, nomUsua, contra, contraRep);

                return resultado;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
