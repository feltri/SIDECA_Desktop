using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIDECA
{
    class Post
    {

        public static Boolean cadCatPost(string descricao)
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO Categoria (descricao) " + "VALUES ('" + descricao + "')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

    }
}
