using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordem_Crescente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmOrganizar_Click(object sender, EventArgs e)
        {

            int primeiro = int.Parse(txtPrimeiro.Text);
            int segundo = int.Parse(txtSegundo.Text);
            int terceiro = int.Parse(txtTerceiro.Text);

            if (primeiro == segundo || primeiro == terceiro || terceiro == segundo)
            {
                MessageBox.Show("Insira apenas valores distintos!");
            }
            else if (primeiro < segundo && primeiro < terceiro) //testar se o primeiro valor é o menor
            {
                txtMenor.Text = primeiro.ToString();

                if (segundo < terceiro)                       //se o primeiro valor for o menor, testa a relação entre o 2 e 3
                {
                    txtMedio.Text = segundo.ToString();
                    txtMaior.Text = terceiro.ToString();    
                }
                else
                {
                    txtMedio.Text = terceiro.ToString();
                    txtMaior.Text = segundo.ToString();     //e mostra
                }

            }
            else if (segundo < primeiro && segundo < terceiro) //testar se o segundo valor é o menor
            {
                txtMenor.Text = segundo.ToString();

                if (primeiro < terceiro)                      //se o segundo valor é o menor, testa a relação entre o 1 e 3
                {
                    txtMedio.Text = primeiro.ToString();
                    txtMaior.Text = terceiro.ToString();
                }
                else
                {
                    txtMedio.Text = terceiro.ToString();
                    txtMaior.Text = primeiro.ToString();   //e mostra
                }
            }
            else if (terceiro < primeiro && terceiro < segundo) //testar se o terceiro valor é o menor
            {
                txtMenor.Text = terceiro.ToString();

                if (primeiro < segundo)                         //se o terceiro valor é o menor, testa a relação entre o 1 e 2
                {
                    txtMedio.Text = primeiro.ToString();
                    txtMaior.Text = segundo.ToString();
                }
                else
                {
                    txtMedio.Text = segundo.ToString();
                    txtMaior.Text = primeiro.ToString();    //e mostra
                }
            }

            txtPrimeiro.Clear();
            txtSegundo.Clear();
            txtTerceiro.Clear();
            txtPrimeiro.Focus();                
        }

        private void txtPrimeiro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            const char virgula = (char)188;
            const char ponto = (char)190;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Insira valores inteiros!");
            }
        }

        private void txtMedio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            const char virgula = (char)188;
            const char ponto = (char)190;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Insira valores inteiros!");
            }
        }

        private void txtMaior_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            const char virgula = (char)188;
            const char ponto = (char)190;

            if (!Char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Insira valores inteiros!");
            }
        }
    }
}
