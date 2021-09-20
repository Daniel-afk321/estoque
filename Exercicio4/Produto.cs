using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Produto
    {
        //declaração de variaveis
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Construtor padrão
        public Produto()
        {
        }

        //Construtor personalizado
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Utilização do GET e SET
        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        //Utilização do GET e SET
        public int GetQuantidade()
        {
            return _quantidade;
        }

        //o valor total no estoque
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        //adiciona produto
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        // remover o produto
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome 
                + ", R$ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + _quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
