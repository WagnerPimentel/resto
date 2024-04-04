using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace resto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 

        }

        private void button1_Click(object sender, EventArgs e)
        {
        int dividendo = Convert.ToInt32(txtDividendo.Text);
        int divisor = Convert.ToInt32(txtDivisor.Text);
        int resto = dividendo % divisor;
        txtRestoDaDivisao.Text = resto.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int soma1 = Convert.ToInt32(txtSoma1.Text);
            int soma2 = Convert.ToInt32(txtSoma2.Text);
            int resultadoSoma = soma1 + soma2;
            txtResultadoSoma.Text = resultadoSoma.ToString();   
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int subtracao1 = Convert.ToInt32(txtSubtracao1.Text);
            int subtracao2 = Convert.ToInt32(txtSubtracao2.Text);
            int resultadoSubtracao = subtracao1 - subtracao2;
            txtResultadoSubtracao.Text = resultadoSubtracao.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int multiplicacao1 = Convert.ToInt32(txtMultiplicacao1);
            int multiplicacao2 = Convert.ToInt32(txtMultiplicacao2);
            int resultadoMultiplicacao = multiplicacao1 * multiplicacao2;
            txtResultadoMultiplicacao.Text = resultadoMultiplicacao.ToString();
        }
    }
}
