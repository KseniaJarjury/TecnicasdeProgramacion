using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_CapaDato
{
    public class Cliente
    {
        public bool altaCliente(string nombre, string apellido, string dni, string dom, string CP, string email, DateTime fNac, string tel, string nomUsua, string contra, string contraRep)
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
                        command.CommandText = "insert into Cliente values(@dni,@nomUsu,@nombre,@apellido,@dom,@email,@CP,@fNac,@tel)";
                        command.Parameters.AddWithValue("@nombre", nombre);
                        command.Parameters.AddWithValue("@apellido", apellido);
                        command.Parameters.AddWithValue("@dni", dni);
                        command.Parameters.AddWithValue("@dom", dom);
                        command.Parameters.AddWithValue("@CP", CP);
                        command.Parameters.AddWithValue("@email", email);
                        command.Parameters.AddWithValue("@fNac", fNac);
                        command.Parameters.AddWithValue("@tel", tel);
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
