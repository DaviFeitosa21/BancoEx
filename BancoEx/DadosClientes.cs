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
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Deposito { get; private set; }

        public DadosClientes(int NumeroConta, string NomeTitular)
        {
            this.NumeroConta = NumeroConta;
            this.NomeTitular = NomeTitular;
        }

        public DadosClientes(int numeroConta, string nomeTitular, double deposito) : this(numeroConta, nomeTitular)
        {
            Deposito = deposito;
        }

        public void AdicionarValor(double adicionarvalor)
        {
            Deposito += adicionarvalor;
        }

        public void SacarValor(double sacarvalor)
        {
            Deposito -= sacarvalor + 5.0;
        }

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
