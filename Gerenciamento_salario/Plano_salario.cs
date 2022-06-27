using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciando_salario
{
    internal class Empregado
    {
        public string nome;
        public string cargo;
        public double reajusteSalarial;

        public Empregado(string nome, string cargo, double salarioMensal)
        {
            this.nome = nome;
            this.cargo = cargo;
            this.reajusteSalarial = salarioMensal;
            // this.reajusteSalarial = reajusteSalarial;
        }
        public void SalarioMensal()
        {
            double meusalario = this.reajusteSalarial;
            double reajusteSalarial;

            if (meusalario < 0)
            {
                meusalario = 0.0;
            }
            else if (meusalario >= 0 && meusalario <= 400.00)
            {
                reajusteSalarial = meusalario * 1.15;
                Console.WriteLine($"Parabéns. Seu salário reajustado é R$: {reajusteSalarial.ToString("F2")}");
            }
            else if (meusalario >= 401.00 && meusalario <= 800.00)
            {
                reajusteSalarial = meusalario * 1.12;
                Console.WriteLine($"Parabéns. Seu salário reajustado é R$: {reajusteSalarial.ToString("F2")}");
            }
            else if (meusalario >= 800.01 && meusalario <= 12.000)
            {
                reajusteSalarial = meusalario * 1.10;
                Console.WriteLine($"Parabéns.Seu salário reajustado é R$: {reajusteSalarial.ToString("F2")}");
            }
            else if (meusalario >= 12.001 && meusalario <= 20.000)
            {
                reajusteSalarial = meusalario * 1.07;
                Console.WriteLine($"Parabéns.Seu salário reajustado é R$: {reajusteSalarial.ToString("F2")}");
            }
            else
            {

                reajusteSalarial = meusalario * 1.04;
                Console.WriteLine($"Parabéns.Seu salário reajustado é R$: {reajusteSalarial.ToString("F2")}");

            }

        }
        public void ReajusteSalario()
        {
            Console.WriteLine($"Nome do funcionário: {nome}");
            Console.WriteLine($"Cargo do funcionário: {cargo}");
            Console.WriteLine($"Seu novo salário é: {reajusteSalarial.ToString("F2")}");
        }

    }
}
