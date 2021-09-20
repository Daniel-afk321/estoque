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
        //variaveis 
        private string _nome;
        private double _preco;
        private int _quantidade;
        private int Leght;

        // construtor padrao 
        public Produto()
        {
           
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
               // if (value != null || !value Leght > 1)
               // {
                  //  _nome = value;
                //}
            }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        // metodo valor total do estoque
        public double ValorTotalEmEstoque() { 
            return _preco * _quantidade;
        }

        //metodo adicionar produto
        public void AdicionarProduto(int quantidade) { 
            _quantidade += quantidade; 
        }


        //metodo remover produto
        public void RemoverProduto(int quantidade) {
            _quantidade -= quantidade;
                
        }

        public override string ToString() {
            return  _nome 
                + ", R$ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + _quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
