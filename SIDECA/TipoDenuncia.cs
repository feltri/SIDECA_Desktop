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
    public partial class TipoDenuncia : Form
    {
        public TipoDenuncia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadDenuncia cad5 = new CadDenuncia();
            cad5.Show();
        }
    }
}
