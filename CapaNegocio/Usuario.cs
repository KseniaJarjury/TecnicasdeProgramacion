using DAL_CapaDato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;




namespace BLL_CapaNegocio
{
    public class Usuario 
    {
        Usuariodao dbUsuario = new Usuariodao();
        public bool altaUsuario(string nombreUsuario, string contra)
        {
            try
            {
                bool resultado;

                resultado = dbUsuario.altaUsuario(nombreUsuario, contra);

                return resultado;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public string VerificarUsuario(string nombreUsuario)
        {
            try
            {
                string tipoUsuario;

                tipoUsuario = dbUsuario.VerificarUsuario(nombreUsuario);

                return tipoUsuario;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public bool Login(string nombreUsuario, string contra)
        {
            try
            {
                bool resultado;

                resultado = dbUsuario.Login(nombreUsuario, contra);

                return resultado;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

    }
}