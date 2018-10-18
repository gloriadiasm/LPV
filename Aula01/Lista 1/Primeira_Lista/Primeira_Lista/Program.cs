using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeira_Lista
{
    class Program
    {
        static void exercicio1()
        {
            double num1, num2;
            char operacao;
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Entre com um número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite outro numero: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite uma operação (+, -, *, /)");
                operacao = Convert.ToChar(Console.ReadLine());

                switch (operacao)
                {
                    case '+':
                        Console.WriteLine("Soma=" + (num1 + num2));
                        break;
                    case '-':
                        Console.WriteLine("Subtração=" + (num1 - num2));
                        break;
                    case '*':
                        Console.WriteLine("Multiplicação=" + (num1 * num2));
                        break;
                    case '/':
                        Console.WriteLine("Divisão=" + (num1 / num2));
                        break;
                    default:
                        Console.WriteLine("Operação invalida");
                        break;
                }
                Console.WriteLine("Deseja continuar? (S ou N)");
                operacao = Convert.ToChar(Console.ReadLine());
                if (operacao == 'N')
                    break;
            }
        }

        static void exercicio2()
        {
            int fat, num, i;
            char operac;
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Qual número fatorial você deseja calcular de forma iterativa? ");
                num = Convert.ToInt32(Console.ReadLine());

                fat = 1;

                for (i = 1; i <= num; i = i + 1)
                {
                    fat = fat * i;
                }
                Console.WriteLine(fat);
                Console.WriteLine("Deseja calcular o fatorial de forma iterativa de novo? (S ou N)");
                operac = Convert.ToChar(Console.ReadLine());
                if (operac == 'N')
                    Console.Clear();
                break;

            }
        }
        static int exercicio3(int n)
        {

            if (n == 0 || n == 1)
                return 1;
            else
                return (n * exercicio3(n - 1));
        }
        static void exercicio4()
        {
            int i = 0, n;
            int j = 1;

            while (true)
            {
                Console.WriteLine("Digite quantos números da sequência fibonacci deseja ver de forma iterativa: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 1 || n == 2)
                    Console.WriteLine("1");

                for (int k = 0; k < n; k++)
                {
                    int t;
                    t = i + j;
                    i = j;
                    j = t;
                    Console.WriteLine(j);
                }

                Console.WriteLine("Deseja ver a seqeuencia de fibonacci de forma iterativa de novo? (S ou N)");
                char s = Convert.ToChar(Console.ReadLine());
                if (s == 'N')
                    Console.Clear();
                break;
            }
        }

        static int exercicio5(int n)
        {

            if (n < 2)

                return n;

            else

                return exercicio5(n - 2) + exercicio5(n - 1);
            
        }
        static void exercicio6()
        {
            while (true)
            {
                String str1;
                Console.WriteLine("Digite uma frase: ");
                str1 = Console.ReadLine();

                String str2;
                Console.WriteLine("Digite outra frase: ");
                str2 = Console.ReadLine();


                if (str1.Contains(str2))
                {
                    Console.WriteLine(str1 + " contém " + str2);
                }
                else if (str2.Contains(str1))
                {
                    Console.WriteLine(str2 + " contém " + str1);
                }
                else
                    Console.WriteLine("Nenhuma frase está contida  na  outra");
                Console.WriteLine("Deseja ver se uma frase está contida em outra de novo? (S ou N)");
                char b = Convert.ToChar(Console.ReadLine());
                if (b == 'N')
                    Console.Clear();
                break;
            }
        }
        static void exercico7()
        {
            String numero;

            Console.WriteLine("Digite um número com formato válido (dddd-dddd)");
            numero = Console.ReadLine();

            for(int i=0; i<9; i++)
            {
                if (numero[i] == i)
                    if (numero[4] == '-')
                        Console.WriteLine("Formato válido");
            }
            Console.Clear();
        }
        static void exercicio8()
        {
             int i = 0, n;
            int j = 1;

            while (true)
            {
                Console.WriteLine("Digite quantos números da sequência fibonacci deseja ver de forma iterativa: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n == 1 || n == 2)
                    Console.WriteLine("1");

                for (int k = 0; k < n; k++)
                {
                    int t;
                    t = i + j;
                    i = j;
                    j = t;
                    Console.WriteLine(j);
                }

                Console.WriteLine("Deseja ver a seqeuencia de fibonacci de forma iterativa de novo? (S ou N)");
                char s = Convert.ToChar(Console.ReadLine());
                if (s == 'N')
                    Console.Clear();
                break;
            }
        }
        static int exercicio9(int n)
        {
            if(n < 2)

                return n;

            else

                return exercicio5(n - 2) + exercicio5(n - 1);

        }

        static void Main(string[] args)
        {


            exercicio1();
            exercicio2();
            int n;
            char s;
            while (true)
            {
                Console.WriteLine("Digite o numero fatorial que deseja calcular de forma recursiva ");
                n = Convert.ToInt32(Console.ReadLine());
                int resultado = exercicio3(n);
                Console.WriteLine(resultado);
                Console.WriteLine("\nDeseja calcular o fatorial de forma recursiva de novo? (S ou N)");
                s = Convert.ToChar(Console.ReadLine());
                if (s == 'N')
                    Console.Clear();
                break;
            }
            exercicio4();
            while (true)
            {
                Console.WriteLine("Digite quantos números da sequência fibonacci deseja ver de forma recursiva: ");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                    Console.WriteLine(exercicio5(i));
                
                Console.WriteLine("Deseja ver a seqeuencia de fibonacci de forma recursiva de novo? (S ou N)");
                char x = Convert.ToChar(Console.ReadLine());
                if (x == 'N')
                    Console.Clear();
                break;
            }
            exercicio6();
            exercico7();
            exercicio8();
            while (true)
            {
                Console.WriteLine("Digite quantos números da sequência fibonacci deseja ver de forma recursiva: ");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                    Console.WriteLine(exercicio9(i));

                Console.WriteLine("Deseja ver a seqeuencia de fibonacci de forma recursiva de novo? (S ou N)");
                char x = Convert.ToChar(Console.ReadLine());
                if (x == 'N')
                    Console.Clear();
                break;
            }

        }
    }
}
