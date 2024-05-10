using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Agressor agressor = new Agressor(comboBox1.Text);
            MySqlDataReader r = agressor.consultarTipoAgressor();
            if (r.HasRows)
            {
                while (r.Read())
                {
                    textBox2.Text = (r["descricao"].ToString());
                }
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
