using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 15;
            Pessoa[] p = new Pessoa[TAM];
            int c = 0;
            int op = 0;
            do
            {
                op = menu();
                switch (op)
                {
                    case 1: p[c++] = cadastrarPessoa(); break;
                    case 2: listarPessoa(p, c); break;
                    case 3: exibirMediaPesoIDeal(p, "MASCULINO", c); break;
                    case 4: exibirMediaPesoIdeal(p, "FEMININO", c); break;
                    case 0: break;

                    default: Console.WriteLine("Opção Inválida."); break;
                }
                Console.SetCursorPosition(50, 20);
                Console.Write("Tecle algo para continuar!");
                Console.ReadKey();
            } while (op != 0);
        }

        public static int menu()
        {
            Console.Clear();
            Console.WriteLine("*** Menu Principal - Pessoas***\n");
            Console.WriteLine(" 1 - Cadastrar");
            Console.WriteLine(" 2 - Listar todas as pessoas");
            Console.WriteLine(" 3 - Média do Prso Ideal dos Homens");
            Console.WriteLine(" 4 - Média do Peso Ideal das Mulheres");
            Console.WriteLine(" 0 - Sair");
            Console.Write("/n Digite uma opção: ");
            return int.Parse(Console.ReadLine());
        }

    }
}
