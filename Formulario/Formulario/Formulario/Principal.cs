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
            Tela2 tl2 = new Tela2();
            tl2.MdiParent = this;
            tl2.Show();
            this.toolStripStatusLabel1.Text = "Tela1";
        }

        private void tela2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verificar ver = new Verificar();
            ver.MdiParent = this;
            ver.Show();
            this.toolStripStatusLabel1.Text = "Verificar Número ";
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastro cd = new Cadastro();
            cd.MdiParent = this;
            cd.Show();
            this.toolStripStatusLabel1.Text = "Cadastrar Usuário";
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Tema Tema = new Tema();
            Tema.MdiParent = this;
            Tema.Show();
            this.toolStripStatusLabel1.Text = "Mudar Tema";
        }

        private void nomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nomes Nomes = new Nomes();
            Nomes.MdiParent = this;
            Nomes.Show();
            this.toolStripStatusLabel1.Text = "Nomes";
        }
    }
}
