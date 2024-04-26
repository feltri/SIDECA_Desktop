using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIDECA
{
     class Denuncias
    {
        private string Descricao;
        private int id;

        public void setId(int id)
        {
            this.id = id; 
        }

        public int getId()
        {
            return this.id;
        }

        public void setDescricao(string Descricao)
        {
            this.Descricao = Descricao;
        }

        public string getDescricao()
        {
            return this.Descricao;
        }

        public static Boolean cadDenuncia(string descricao)
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO TipoDenuncia (descricao) " + "VALUES ('" + descricao + "')", DAO_Conexao.con);
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


            /*public bool excluirDenuncia()
            {

                //temos que fazer as tabelas e alterar o WHERE
                bool exclui = false;
                try
                {
                    DAO_Conexao.con.Open();
                    MySqlCommand update = new MySqlCommand("UPDATE TipoDenuncia SET ativo=0 WHERE descricao = '" + Descricao1 + "'", DAO_Conexao.con);

                    update.ExecuteNonQuery();
                    exclui = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    DAO_Conexao.con.Close();

                }
                return exclui;
            }*/
        }
}
