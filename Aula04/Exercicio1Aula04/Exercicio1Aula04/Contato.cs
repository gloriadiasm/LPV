using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio1Aula04
{
    public class Contato
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }


        public Contato()
        {
        }

        public Contato (int id, string nome, string endereco, string telefone)
	    {
            this.Id = id;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
	    }

    }
}
