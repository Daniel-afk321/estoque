using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // entrada dos dados do produto do usuario
            Console.WriteLine("Entre com os dados do produto;"); 

            // nome do produto
            Console.Write("Nome: "); 
            string nome = Console.ReadLine(); 

            //preço do produto
            Console.Write("Preço: "); 
             double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // quantidade de produto no estoque
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //instanciando
            Produto p = new Produto(nome, preco, quantidade);
            
            //dados do produto
            Console.WriteLine("Dados do produto: " + p); 

            //adicionar produto no estoque
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: "); 
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte); 

            Console.WriteLine("Dados do atualizados: " + p);

            // remover produto do estoque 
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: "); 
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte); 

            Console.WriteLine("Dados do atualizados: " + p);
        }
    }
}
