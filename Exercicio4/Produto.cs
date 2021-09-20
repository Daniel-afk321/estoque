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
        private string _nome;
        public double _Preco{get; private set;}
        public double Quantidade{get; private set;}

        // construtor padrao
        public Produto()
        {
        }

        // construtor
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _Preco = preco;
            Quantidade = quantidade;
        }

        // parecido com Declaração de variavel  ------- properties
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
      
        // metodo valor total do estoque
        public double ValorTotalEmEstoque() {
            get {return _Preco * Quantidade; }
            
                
        }

        //metodo adicionar produto
        public void AdicionarProdutos(int quantidade) { 
            Quantidade += quantidade; 
        }


        //metodo remover produto
        public void RemoverProdutos(int quantidade) { 
            Quantidade -= quantidade; 
        }

        public override string ToString() {
            return _nome 
                + ", R$ "
                + _Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
