using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace EstoqueComConstrutor
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() { } // construtor padrao, vazio

        public Produto(string nome, double preco, int quantidade) // construtor, mesmo nome da classe
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public Produto(string nome, double preco) // construtor de sobrecarga
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 0; // se for iniciar em zero, nao e necessario especificar
        }

        /*
        Contrutores com this

        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade):this(nome, preco)
        {
            Quantidade = quantidade;
        }
        */


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
