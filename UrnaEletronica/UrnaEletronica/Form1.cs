using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Form1 : Form
    {
        int daniel = 0;
        int dionei = 0;
        int edir = 0;
        int ismael = 0;
        int ivan = 0;
        int jorge = 0;
        int sergio = 0;
        int crey = 0;
        int nulo = 0;

        public Form1()
        {
            InitializeComponent();
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           if(textBox1.Text == "69")
            {
                pictureBox1.Image = Properties.Resources.crey;
                textBox2.Text = "Seu Creysson";
                textBox3.Text = "PDSC";
            }

            else if(textBox1.Text == "28")
            {
                pictureBox1.Image = Properties.Resources.didi;
                textBox2.Text = "Edir Macedo";
                textBox3.Text = "PUDRD";
            }

               else if (textBox1.Text == "45")
            {
                pictureBox1.Image = Properties.Resources.peppa;
                textBox2.Text = "Sergio Peppa";
                textBox3.Text = "PDPP";
            }

            else if (textBox1.Text == "19")
            {
                pictureBox1.Image = Properties.Resources._4_0;
                textBox2.Text = "Dionei Pegador";
                textBox3.Text = "PDP";
            }

            else if (textBox1.Text == "11")
            {
                pictureBox1.Image = Properties.Resources.jorge;
                textBox2.Text = "Jorge da Novinha";
                textBox3.Text = "PDN";
            }

            else if (textBox1.Text == "72")
            {
                pictureBox1.Image = Properties.Resources.daniel;
                textBox2.Text = "Daniel Bufala";
                textBox3.Text = "PDD";
            }

            else if (textBox1.Text == "50")
            {
                pictureBox1.Image = Properties.Resources.mael;
                textBox2.Text = "Mael Modelo";
                textBox3.Text = "PDM";
            }
            else if (textBox1.Text == "31")
            {
                pictureBox1.Image = Properties.Resources.ivan;
                textBox2.Text = "Ivan Sacudo";
                textBox3.Text = "PDS";
            }
            else
            {
                pictureBox1.Image = Properties.Resources.semfoto;
                textBox2.Text = "Não existe";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.branco;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "69")
            {
                crey += 1;
                textBox4.Text = Convert.ToString(crey);
            }
            else if(textBox1.Text == "19")
            {
                dionei += 1;
                textBox6.Text = Convert.ToString(dionei);
            }
            else if (textBox1.Text == "72")
            {
                daniel += 1;
                textBox5.Text = Convert.ToString(daniel);
            }
            else if (textBox1.Text == "28")
            {
                edir += 1;
                textBox7.Text = Convert.ToString(edir);
            }
            else if (textBox1.Text == "50")
            {
                ismael += 1;
                textBox8.Text = Convert.ToString(ismael);
            }
            else if (textBox1.Text == "31")
            {
                ivan += 1;
                textBox9.Text = Convert.ToString(ivan);
            }
            else if (textBox1.Text == "11")
            {
                jorge += 1;
                textBox10.Text = Convert.ToString(jorge);
            }
            else if (textBox1.Text == "45")
            {
                sergio += 1;
                textBox11.Text = Convert.ToString(sergio);
            }
            else 
            {
                nulo += 1;
                textBox12.Text = Convert.ToString(nulo);
            }

            panel1.Visible = true;

            //Todo: alterar pelo timer
            for (int i = 0; i < 1000000555; i++)
            {

            }

            panel1.Visible = false;


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
