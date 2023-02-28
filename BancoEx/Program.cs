using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BancoEx
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DadosClientes dados = null;

            Console.WriteLine("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Console.WriteLine("Deseja fazer um depósito inicial? (S/N)");
            char validacao = char.Parse(Console.ReadLine());

            if(validacao == 's')
            {
                Console.WriteLine("Entre o valor de deposito inicial: ");
                double depositoIni = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                dados = new DadosClientes(numeroConta, nomeTitular, depositoIni);
            }
            else
            {
                dados = new DadosClientes(numeroConta, nomeTitular);
                Console.WriteLine("Seu valor inicial será: R$ 0");
            }

            Console.WriteLine("");
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(dados);

            Console.WriteLine("");
            Console.WriteLine("Entre um valor para deposito: ");
            double ValorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.AdicionarValor(ValorDeposito);

            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(dados);

            Console.WriteLine("");
            Console.WriteLine("Entre um valor para saque: ");
            double ValorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dados.SacarValor(ValorSaque);

            Console.WriteLine("");
            Console.WriteLine("Dados atualizados: ");
            Console.WriteLine(dados);

        }
    }
}
