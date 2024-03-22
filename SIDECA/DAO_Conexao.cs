using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIDECA
{
    class DAO_Conexao
    {
        public static SqlConnection con;
        public static Boolean getConexao(String local, String user, String banco, String senha)
        {
            Boolean retorno = false;
            try
            {
                con = new SqlConnection("server=" + local + ";User ID=" + user + ";" +
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
                SqlCommand login = new SqlCommand("Select * from Estudio_Login where usuario = '" + usuario + "' and senha = '" + senha + "'", con);
                SqlDataReader resultado = login.ExecuteReader();
                if (resultado.Read())
                {
                    tipo = Convert.ToInt32(resultado["tipo"].ToString());
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
                SqlCommand insere = new SqlCommand("insert into Estudio_Login (usuario, senha, tipo) " +
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
