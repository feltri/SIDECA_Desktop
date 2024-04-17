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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl201111", "cl201111", "cl*02062006"))
            {
                Console.WriteLine("Conectado");
            }
            else
                Console.WriteLine("Erro de conexão");
        }
        private void agressorToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gerenciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.login(textBox1.Text, textBox2.Text);
        
            if (tipo == 0)
                MessageBox.Show("Usuário/Senha inválidos");
            if (tipo == 1)
            {
                MessageBox.Show("Usuário ADM");
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agressorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<TipoAgressor>().Count() == 0)
            {
                TipoAgressor user = new TipoAgressor();
                user.MdiParent = this;
                user.Show();
            }
        }

        private void denúnciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void postToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void relatóriosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
