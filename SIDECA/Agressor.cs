﻿using System;
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
        public bool cadastrarAgressor()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                SqlCommand insere = new SqlCommand("insert into TipoAgressor (descricao) values ('" + Descricao + "')", DAO_Conexao.con);

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

        public bool consultarAgressor()
        {
            Boolean existe = false;
            try
            {
                DAO_Conexao.con.Open();
                SqlCommand consulta = new SqlCommand("SELECT  * FROM TipoAgressor   WHERE descricao= '" + getDescricao() + "'", DAO_Conexao.con);
                SqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();

            }
            return existe;
        }

        public bool excluirAluno()
        {
            Boolean existe = false;
            try
            {
                DAO_Conexao.con.Open();
                SqlCommand consulta = new SqlCommand ("DELETE * FROM TipoAgressor   WHERE descricao= '" + Descricao + "'", DAO_Conexao.con);
                SqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();

            }
            return existe;
        }


    }
}
