using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX04___numeros_complexos
{
    class Teste
    {
        static void Main(string[] args)
        {
            // instancia n1 e n2 passando parametros
            double real1, real2, imag1, imag2;

            Console.WriteLine("Digite a parte real do primeiro numero: ");
            real1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a parte imaginaria do primerio numero: ");
            imag1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a parte real do segundo numero: ");
            real2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a parte imaginaria do segundo numero: ");
            imag2 = Convert.ToDouble(Console.ReadLine());

            NumeroComplexo n1 = new NumeroComplexo(real1, imag1);
            Console.WriteLine("n1 = " +n1);
            NumeroComplexo n2 = new NumeroComplexo(real2, imag2);
            Console.WriteLine("n2 = " + n2);
            NumeroComplexo n3 = n1.Soma(n2);

            Console.WriteLine("Soma de n1 + n2 = "+n3);
            n3 = n1.Subt(n2);
            Console.WriteLine("Subtração de n1 - n2 = " + n3);
            Console.ReadKey();
        }
    }
}
