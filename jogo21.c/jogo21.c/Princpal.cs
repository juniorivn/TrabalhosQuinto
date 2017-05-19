using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo21.c
{
    public partial class Princpal : Form
    {
        int jogadas = 0;
        int pjog = 0;
        int pban = 0;
        int jogador = 0;
        int banca = 0 ;
        Label lbl = new Label();
        

        public Princpal()
        {
            InitializeComponent();
            label1.Parent = pictureBox4;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox4;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox4;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox4;
            label4.BackColor = Color.Transparent;
            label5.Parent = pictureBox4;
            label5.BackColor = Color.Transparent;

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            {
                Random randNum = new Random();
                int x = randNum.Next(1, 14);
                if ( jogador == 0)
                {
                    
                    jogador = x + jogador;
                    this.label4.Text = Convert.ToString("Total = " + jogador);
                    this.listBox1.Items.Add("Carta (" + x + ")");
                    int j = randNum.Next(1, 14);
                    x = j;
                }

                switch (x)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources._1;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources._2;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources._3;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources._4;
                        break;
                    case 5:
                        pictureBox1.Image = Properties.Resources._5;
                        break;
                    case 6:
                        pictureBox1.Image = Properties.Resources._6;
                        break;
                    case 7:
                        pictureBox1.Image = Properties.Resources._7;
                        break;
                    case 8:
                        pictureBox1.Image = Properties.Resources._8;
                        break;
                    case 9:
                        pictureBox1.Image = Properties.Resources._9;
                        break;
                    case 10:
                        pictureBox1.Image = Properties.Resources._10;
                        break;
                    case 11:
                        pictureBox1.Image = Properties.Resources._11;
                        break;
                    case 12:
                        pictureBox1.Image = Properties.Resources._12;
                        break;
                    case 13:
                        pictureBox1.Image = Properties.Resources._13;
                        break;
                }

                jogador = x + jogador;
                this.label4.Text = Convert.ToString("Total = "+jogador);
                this.listBox1.Items.Add("Carta ("+x+")");
                this.button5.Enabled = true;
                if (jogador > 21)
                {
                        

                    this.button1.Enabled = false;
                    this.pictureBox3.Visible = true;
                    this.pictureBox3.Image = Properties.Resources.lose;
                    this.button2.Enabled = true;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    
                }
                else if (jogador == 21){
                    this.button1.Enabled = false;
                    this.button5.Enabled = false;
                    this.button4.Enabled = true;
                }
           }
       }

        private void button2_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            this.label4.Text = " ";
            jogador = 0;
            this.button1.Enabled = true;
            this.listBox2.Items.Clear();
            this.label5.Text = " ";
            banca = 0;
            this.button2.Enabled = false;
            this.pictureBox1.Image = Properties.Resources.inicio;
            this.pictureBox2.Image = Properties.Resources.inicio;
            this.pictureBox3.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random randNum = new Random();
            int y = randNum.Next(1,14);
            

            if (banca == 0)
            {

                banca = y + banca;
                this.label5.Text = Convert.ToString("Total = " + jogador);
                this.listBox2.Items.Add("Carta (" + y + ")");
                int i = randNum.Next(1, 14);
                y = i;
                
            }

            switch (y)
            {
                case 1:
                    pictureBox2.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox2.Image = Properties.Resources._2;
                    break;
                case 3:
                    pictureBox2.Image = Properties.Resources._3;
                    break;
                case 4:
                    pictureBox2.Image = Properties.Resources._4;
                    break;
                case 5:
                    pictureBox2.Image = Properties.Resources._5;
                    break;
                case 6:
                    pictureBox2.Image = Properties.Resources._6;
                    break;
                case 7:
                    pictureBox2.Image = Properties.Resources._7;
                    break;
                case 8:
                    pictureBox2.Image = Properties.Resources._8;
                    break;
                case 9:
                    pictureBox2.Image = Properties.Resources._9;
                    break;
                case 10:
                    pictureBox2.Image = Properties.Resources._10;
                    break;
                case 11:
                    pictureBox2.Image = Properties.Resources._11;
                    break;
                case 12:
                    pictureBox2.Image = Properties.Resources._12;
                    break;
                case 13:
                    pictureBox2.Image = Properties.Resources._13;
                    break;
            }


            banca = y + banca;
            
            if (banca >= 21)
            {
                int aux;
                aux =   banca - y ;
                y = 21 - aux;
                banca = 21;
                this.label5.Text = Convert.ToString("Total = 21 " ); ;
                this.listBox2.Items.Add("Carta (" + y + ")");
                

                if (banca == jogador)
                {
                    this.pictureBox3.Visible = true;
                    this.pictureBox3.Image = Properties.Resources.empate;
                }
                else
                {
                    this.pictureBox3.Visible = true;
                    //MessageBox.Show("Banca Ganhou");
                    this.pictureBox3.Image = Properties.Resources.lose;
                }
                this.button2.Enabled = true;
                this.button1.Enabled = false;
                this.button4.Enabled = false;
                this.button5.Enabled = false;

            }
            else
            {
                this.label5.Text = Convert.ToString("Total =" + banca);
                this.listBox2.Items.Add("Carta (" + y + ")");
            }

          

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button5.Enabled = false;
            this.button4.Enabled = true;

        }
    }
}
