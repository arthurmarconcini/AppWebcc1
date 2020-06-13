using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;




namespace AppWeb.Models
{
    public class Conexao
    {
        public static SqlConnection Conectar()
        
        {
            string conexao = @"Data Source=DESKTOP-7GM6PF4\SQLEXPRESS;Initial Catalog=WebApp;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();
            return connection;
        
        }                          
                               
                             

        
    }
}
