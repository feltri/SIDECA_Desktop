using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SIDECA
{
    class Agressor
    {
        private string Descricao;

        public Agressor(string descricao)
        {
            setDescricao(descricao);
        }

        public void setDescricao (string Descricao)
        {
            this.Descricao = Descricao;
        }

        public string getDescricao()
        {
            return this.Descricao;
        }


        public static Boolean CadAgressor(string descricao)
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("INSERT INTO TipoAgressor (descricao) " + "VALUES ('" + descricao + "')", DAO_Conexao.con);
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
