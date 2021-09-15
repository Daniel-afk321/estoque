using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Produto
    {
        //variaveis 
            public string Nome;
            public double Preco;
            public int Quantidade;

        // construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            
        }

        // metodo valor total do estoque
        public double ValorTotalEmEstoque() { 
            return Preco * Quantidade;
        }

        //metodo adicionar produto
        public void AdicionarProduto(int quantidade) { 
            Quantidade += quantidade; 
        }


        //metodo remover produto
        public void RemoverProduto(int quantidade) { 
            Quantidade = Quantidade - quantidade; 
        }

        public override string ToString() {
            return Nome 
                + ", R$ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
