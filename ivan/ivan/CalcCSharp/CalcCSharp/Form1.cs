using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcCSharp
{
    public partial class Form1 : Form
    {

        double valor1;
        double valor2;
        double result;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            
            valor1 = double.Parse(txtVlr1.Text);
            valor2 = double.Parse(txtVlr2.Text);
            result = valor1 + valor2;
            txtResult.Text = result.ToString();

            MessageBox.Show("O VITÃO NÃO MUDA  E O VALOR É " + result);

            txtVlr1.Text = (" ");
            txtVlr2.Text = (" ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            valor1 = Convert.ToDouble(txtVlr1.Text);
            valor2 = Convert.ToDouble(txtVlr2.Text);
            result = valor1 - valor2;
            txtResult.Text = result.ToString();

            MessageBox.Show("O VITÃO NÃO MUDA  E O VALOR É " + result);

            txtVlr1.Text = (" ");
            txtVlr2.Text = (" ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txtVlr1.Text);
            valor2 = Convert.ToDouble(txtVlr2.Text);
            result = valor1 * valor2;
            txtResult.Text = result.ToString();

            MessageBox.Show("O VITÃO NÃO MUDA  E O VALOR É " + result);

            txtVlr1.Text = (" ");
            txtVlr2.Text = (" ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToDouble(txtVlr1.Text);
            valor2 = Convert.ToDouble(txtVlr2.Text);
            result = valor1 / valor2;
            txtResult.Text = result.ToString();

            MessageBox.Show("O VITÃO NÃO MUDA  E O VALOR É " + result);

            txtVlr1.Text = (" ");
            txtVlr2.Text = (" ");
        }

        private void txtVlr1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
