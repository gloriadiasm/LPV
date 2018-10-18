using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malopes___ArrayList_2
{
    class Cliente
    {
        private String nome;
        private String telefone;
        private String endereco;

        public Cliente(String Nome, String Telefone, String Endereco)
        {
            this.nome = Nome;
            this.telefone = Telefone;
            this.endereco = Endereco;
        }

        public String getNome()
        {
            return this.nome;
        }

        public String getTelefone()
        {
            return this.telefone;
        }

        public String getEndereco()
        {
            return this.endereco;
        }

        public void setNome(String Nome)
        {
            this.nome = Nome;
        }
        public void setTelefone(String Telefone)
        {
            this.telefone = Telefone;
        }

        public void setEndereco(String Endereco)
        {
            this.endereco = Endereco;

        }
    }
}
