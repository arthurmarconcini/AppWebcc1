using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AppWeb.Models
{
    public class InsercaoUsuario
    {
        public static void InsereUsuario(string nome, string telefone, string email)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = Conexao.Conectar();
            command.CommandText = $"INSERT Usuarios values ('{nome}','{telefone}','{email}')";
            command.ExecuteNonQuery();
        }
    }
}
