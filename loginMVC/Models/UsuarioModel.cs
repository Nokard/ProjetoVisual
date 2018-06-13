using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace loginMVC.Models
{
    public class UsuarioModel
    {

        public static bool ValidarUsuario(string Usuario, string Senha)
        {
            var ret = false;
            using(var conexao = new MySqlConnection())
            {
                //faz a conexao com o banco de dados 
                conexao.ConnectionString = "server = localhost; userid = root; database = visual; password = asdqwe;";
                conexao.Open();

                using (var cmd = new MySqlCommand("verificaCliente", conexao))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("pEmail", Usuario);
                    cmd.Parameters.AddWithValue("pSenha", Senha);

                    //mysqlint = int.Parse(query.ExecuteScalar().ToString());

                    ret = int.Parse(cmd.ExecuteScalar().ToString()) > 0;
                    //ret = ((int)cmd.ExecuteScalar() > 0);
                }
            }
            return ret;
        }


    }
}