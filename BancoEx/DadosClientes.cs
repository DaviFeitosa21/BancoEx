using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BancoEx
{
    internal class DadosClientes
    {
        //Váriaveis
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Deposito { get; private set; }

        //Métodos Constructors
        public DadosClientes(int numeroConta, string nomeTitular)
        {
            this.NumeroConta = numeroConta;
            this.NomeTitular = nomeTitular;
        }

        public DadosClientes(int numeroConta, string nomeTitular, double deposito) : this(numeroConta, nomeTitular)
        {
            this.Deposito = deposito;
        }

        //Método para Depositar Valor
        public void AdicionarValor(double adicionarvalor)
        {
            Deposito += adicionarvalor;
        }

        //Método para Sacar Valor
        public void SacarValor(double sacarvalor)
        {
            Deposito -= sacarvalor + 5.0;
        }

        //Método ToString
        public override string ToString()
        {
            return "Conta: "
                + NumeroConta
                + ", Titular: "
                + NomeTitular
                + ", Saldo: R$"
                + Deposito.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
