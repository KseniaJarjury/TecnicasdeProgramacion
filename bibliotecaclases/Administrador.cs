using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_CapaDato
{
    public class Administrador
    {
        public bool altaEmpleado(string nombre, string apellido, string dni, string dom, string puesto, string cuit, string nomUsua, string contra, string contraRep)
        {
            using (var Conectar = new SqlConnection())
            {
                Conectar.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=EcommerceUpe;Data Source=MININT-Q3PVKIF";
                Conectar.Open();
                using (var command = new SqlCommand())
                {
                    try
                    {
                        command.Connection = Conectar;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "insert into Empleado values(@dni,@apellido,@nombre,@puesto,@dom,@nomUsu,@cuit)";
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@dni", dni);
                        command.Parameters.AddWithValue("@dom", dom);
                        command.Parameters.AddWithValue("@puesto", puesto);
                        command.Parameters.AddWithValue("@cuit", cuit);
                        command.Parameters.AddWithValue("@nomUsu", nomUsua);
                        command.Parameters.AddWithValue("@contra", contra);

                        SqlDataReader reader = command.ExecuteReader();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        return false;
                    }

                }
            }
        }

    }
}
