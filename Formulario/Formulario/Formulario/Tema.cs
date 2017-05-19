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
    public partial class Tema : Form
    {
        public Tema()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem == "Azul")
            {
                this.BackColor = System.Drawing.Color.Blue;
            }
            else if (listBox1.SelectedItem == "Amarelo")
            {
                this.BackColor = System.Drawing.Color.Yellow;
            }

            else if (listBox1.SelectedItem == "Vermelho")
            {
                this.BackColor = System.Drawing.Color.Red;
            }
            else if (listBox1.SelectedItem == "Verde")
            {
                this.BackColor = System.Drawing.Color.Green;
            }
            else if (listBox1.SelectedItem == "Preto")
            {
                this.BackColor = System.Drawing.Color.Black;
            }
            else if (listBox1.SelectedItem == "Cinza")
            {
                this.BackColor = System.Drawing.Color.Gray;
            }
        }
    }
}
