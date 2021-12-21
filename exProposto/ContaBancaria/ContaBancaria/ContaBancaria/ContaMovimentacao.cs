using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ContaBancaria
{
    class ContaMovimentacao
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; }

        public ContaMovimentacao(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular ?? throw new ArgumentNullException(nameof(nomeTitular));
        }

        public ContaMovimentacao(int numeroConta, string nomeTitular, double saldo) : this(numeroConta, nomeTitular)
        {
            Saldo = saldo;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "Conta " 
                    + NumeroConta
                    + ", Titular: "
                    + NomeTitular
                    + ", Saldo: $ "
                    + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
