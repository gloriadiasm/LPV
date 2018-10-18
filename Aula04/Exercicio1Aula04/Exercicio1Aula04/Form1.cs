using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio1Aula04
{
    public partial class Form1 : Form
    {
        private List<Contato> contatos = new List<Contato>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            testeInsertContatos();
        }

        private void testeInsertContatos()
        {
            contatos.Add(new Contato(1, "Fulano de Tal", "Rua Teste, 34", "2323-3434"));
            contatos.Add(new Contato(2, "Beltrano o Tal", "Rua das Flores, 45", "5656-7878"));

            mostrarContatos();
        }

        private void mostrarContatos()
        {
            contatoBindingSource.DataSource = contatos;
            contatoBindingSource.ResetBindings(false);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                contato.Id = Convert.ToInt32(txtId.Text);
                contato.Nome = txtNome.Text;
                contato.Endereco = txtEndereco.Text;
                contato.Telefone = txtTelefone.Text;

                adicionaContato(contato);

            } catch (Exception ex) {

                MessageBox.Show("Dados inválidos!");
            }
        }

        private void adicionaContato(Contato contato)
        {
            Contato contatoBuscado = buscaPorId(contato.Id);

            if (contatoBuscado == null)
            {
                contatos.Add(contato);
                limparCampos();
            }
            else
            {
                int indice = contatos.IndexOf(contatoBuscado);
                contatos[indice] = contato;
            }

            mostrarContatos();
        }

        private Contato buscaPorId(int id)
        {
            foreach (Contato cont in contatos)
            {
                if (cont.Id == id)
                {
                    return cont;
                }
            }
            return null;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Contato contatoSelecionado = (Contato) contatoBindingSource.Current;

            txtId.Text = contatoSelecionado.Id.ToString();
            txtNome.Text = contatoSelecionado.Nome;
            txtEndereco.Text = contatoSelecionado.Endereco;
            txtTelefone.Text = contatoSelecionado.Telefone;

            txtId.ReadOnly = true;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        private void limparCampos()
        {
            txtId.ReadOnly = false;

            txtId.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try {

                Contato contatoSelecionado = (Contato)contatoBindingSource.Current;

                if(MessageBox.Show("Tem certeza???", "Verificação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes) {

                    contatoBindingSource.RemoveCurrent();

                    mostrarContatos();
                    limparCampos();
                }

            }catch(Exception ex){

                MessageBox.Show("Selecione um contato da grid!");
            }
            
        }
    }
}
