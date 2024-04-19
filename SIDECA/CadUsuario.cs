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
    public partial class CadUsuario : Form
    {
        public CadUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DAO_Conexao.CadLogin(textBox2.Text))
                MessageBox.Show("Cadastro Realizado com Sucesso");
            else
                MessageBox.Show("Erro de Cadastro");
        }
    }
}
