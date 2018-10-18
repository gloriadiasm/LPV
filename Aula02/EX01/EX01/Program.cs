using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade  máxima de clientes que deseja adicionar a sua lista: ");
            int quant = Convert.ToInt32(Console.ReadLine());
            Cliente[] clientes = new Cliente[quant];

            int cont = 0;
            String nome, telefone, endereco, loop;
            int i = 0;

            do
            {
               
               
                Console.WriteLine("Nome: ");
                nome = Console.ReadLine();

                Console.WriteLine("Telefone: ");
                telefone = Console.ReadLine();

                Console.WriteLine("Endereço: ");
                endereco = Console.ReadLine();

                clientes[i] = new Cliente(nome, telefone, endereco);

                i++;
                cont++;

                Console.WriteLine("Deseja continuar a adicionar mais clientes? Se sim digite 'sim'");
                loop = Console.ReadLine();
            }
            while (loop == "sim");


            for (int j = 0; j < cont; j++)
                Console.WriteLine("Nome: " + clientes[j].getNome() + " Telefone: " + clientes[j].getTelefone() + " Endereço: " + clientes[j].getEndereco());
            Console.ReadKey();

        }
    }
}
