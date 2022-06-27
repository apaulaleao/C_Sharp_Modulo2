using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciando_salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = ("** Gerenciamento de salario **");
            string nome;
            string cargo;
            double salario;
            int iniciar;


            Console.WriteLine();
            Console.Write("Informe nome funcionario: ");
            nome = Console.ReadLine();

            Console.Write("Informe cargo do funcionario: ");
            cargo = Console.ReadLine();

            Console.Write("Informe salario do funcionário: ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Empregado empregado = new Empregado(nome, cargo, salario);
            do
            {
                Console.WriteLine("Escolha as opçoes abaixo: ");
                Console.WriteLine("(1) Aumento de salário");
                Console.WriteLine("(2)Exibir meu novo salario");
                Console.WriteLine("(3)Sair");
                Console.WriteLine();
                Console.Write("Escolha sua opção: ");
                iniciar = int.Parse(Console.ReadLine());


                switch (iniciar)
                {
                    case 1:
                        empregado.ReajusteSalario();
                        break;
                    case 2:
                        empregado.SalarioMensal();
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            } while (iniciar != 3);
        }
    }
}

