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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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

        private void agressorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 agressor = new Form3();
            agressor.MdiParent = this;
            agressor.Show();
        }

        private void usuárioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 user = new Form2();
            user.MdiParent = this;
            user.Show();
        }

        private void postToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form10 post = new Form10();
            post.MdiParent = this;
            post.Show();
        }

        private void denúnciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 denuncia = new Form4();
            denuncia.MdiParent = this;
            denuncia.Show();

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
