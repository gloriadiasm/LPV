using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string operador;
        int x = 0;
        bool validar = false;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void numeros_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            txtValor.Text = txtValor.Text + botao.Text;
        }

        private void button_limpa_Click(object sender, EventArgs e)
        {
            txtValor.Text = "";
            label1.Text = "";
            x = 0;
            validar = false;
        }

        private void button_adiciona_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                x = x + Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(x) + "+";
                operador = "+";
            }
            else
            {
                label1.Text = txtValor.Text + button_adiciona.Text;
                x = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "+";
                validar = true;
            }
        }

        private void button_subtrai_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                x = x - Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(x) + "-";
                operador = "-";
            }
            else
            {
                label1.Text = txtValor.Text + button_subtrai.Text;
                x = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "-";
                validar = true;
            }
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                x = x / Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(x) + "/";
                operador = "/";
            }
            else
            {
                label1.Text = txtValor.Text + button_divide.Text;
                x = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void button_multiplica_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                x = x + Convert.ToInt32(txtValor.Text);
                label1.Text = Convert.ToString(x) + "*";
                operador = "*";
            }
            else
            {
                label1.Text = txtValor.Text + button_multiplica.Text;
                x = Convert.ToInt32(txtValor.Text);
                txtValor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void button_resultado_Click(object sender, EventArgs e)
        {
            if(operador == "+")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(x + Convert.ToInt32(txtValor.Text));

            }
            else if (operador == "-")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(x - Convert.ToInt32(txtValor.Text));

            }
            else if (operador == "/")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(x / Convert.ToInt32(txtValor.Text));

            }
             else if (operador == "*")
            {
                label1.Text = label1.Text + txtValor.Text + "=";
                txtValor.Text = Convert.ToString(x * Convert.ToInt32(txtValor.Text));

            }
        }
    }
}
