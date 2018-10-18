using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Malopes___ArrayList_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = new List<Cliente>();
            String nome, telefone, endereco, loop;
            int cont=0;

            do {
                Console.WriteLine("Nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Telefone: ");
                telefone = Console.ReadLine();

                Console.WriteLine("Endereço: ");
                endereco = Console.ReadLine();

                clientes.Add(new Cliente(nome, telefone, endereco));

                cont++;

                Console.WriteLine("Deseja continuar a adicionar mais clientes? Se sim digite 'sim'");
                loop = Console.ReadLine();
            }
            while (loop == "sim");

            for (int i = 0; i < cont; i++)
                Console.WriteLine("Nome: "+ clientes[i].getNome() +" Telefone: "+ clientes[i].getTelefone()+ " Endereço: "+clientes[i].getEndereco());
            Console.ReadKey();
        }
    }
}
