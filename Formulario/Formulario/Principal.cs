using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
           
        }

        private void tela1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela1 tl1 = new Tela1();
            tl1.MdiParent = this;
            tl1.Show();
            this.toolStripStatusLabel1.Text = "Tela1";
        }

        private void tela2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tela2 tl2 = new Tela2();
            tl2.MdiParent = this;
            tl2.Show();
            this.toolStripStatusLabel1.Text = "Tela2";
        }
    }
}
