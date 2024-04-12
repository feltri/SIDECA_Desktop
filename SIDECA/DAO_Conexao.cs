using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIDECA
{
    class DAO_Conexao
    {
        public static MySqlConnection con;
        public static Boolean getConexao(String local, String banco, string user, String senha)
        {
            Boolean retorno = false;
            try
            {
                con = new MySqlConnection("server=" + local + ";User ID=" + user + ";" +
                    "database=" + banco + "; password=" + senha);
                //con.Open();
                retorno = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //con.Close();//ajustar
            }
            finally
            {
                //con.Close();
            }
            return retorno;
        }
        public static int login(String usuario, String senha)
        {
            int tipo = 0; //0 quando não encontra
            try
            {
                con.Open();
                MySqlCommand login = new MySqlCommand("Select * from Usuario where login = '" + usuario + "' and senha = '" + PasswordHelper.Encrypt(senha) + "'", con);
                MySqlDataReader resultado = login.ExecuteReader();
                if (resultado.Read())
                {
                    tipo = Convert.ToInt32(resultado["tipoUsuario"].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return tipo;
        }

        public static Boolean CadLogin(string usuario, string senha, int tipo)
        {
            bool cad = false;
            try
            {
                con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Usuario (login, senha, tipoUsuario) " +
                    "values ('" + usuario + "','" + senha + "'," + tipo + ")", con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            return cad;
        }

    }
}
