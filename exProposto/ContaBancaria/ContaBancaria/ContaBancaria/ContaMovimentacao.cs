using System;
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

        public ContaMovimentacao(int numeroConta, string nomeTitular, double depositoInicial) : this(numeroConta, nomeTitular)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
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
