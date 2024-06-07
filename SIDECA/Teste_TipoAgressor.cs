using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIDECA
{
    public partial class Teste_TipoAgressor : Form
    {
        public Teste_TipoAgressor()
        {
            InitializeComponent();
        }

        private void Teste_TipoAgressor_Load(object sender, EventArgs e)
        {
            // Conexão com o banco de dados (substitua as credenciais e a string de conexão conforme necessário)

            DAO_Conexao.con.Open();
            try
            {
                // Abra a conexão


                // Comando SQL para recuperar os dados (substitua "Tabela" pelo nome da sua tabela e "Coluna" pelo nome da coluna cujos valores deseja exibir no ComboBox)
                // string query = "SELECT * FROM agressor";
                MySqlConnection con = DAO_Conexao.con;
                MySqlCommand consulta = new MySqlCommand("SELECT * FROM TipoAgressor", DAO_Conexao.con);

                // Leitura dos dados
                MySqlDataReader reader = consulta.ExecuteReader();

                // Limpe os itens anteriores, caso existam
                comboBox1.Items.Clear();

                // Adicione os dados ao ComboBox
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["descricao"].ToString());
                }

                // Feche o leitor
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                // Feche a conexão
                DAO_Conexao.con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
