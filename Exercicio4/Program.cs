using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // esta instanciando
            Produto p = new Produto(); 

            // entrada dos dados do produto do usuario
            Console.WriteLine("Entre com os dados do produto;"); 

            // nome do produto
            Console.Write("Nome: "); 
            p.Nome = Console.ReadLine(); 

            //preço do produto
            Console.Write("Preço: "); 
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // quantidade de produto no estoque
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            
            //dados do produto
            Console.WriteLine("Dados do produto: " + p); 

            //adicionar produto no estoque
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: "); 
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte); 

            Console.WriteLine("Dados do atualizados: " + p);

            // remover produto do estoque 
            Console.WriteLine("Digite o número de produtos a serem removidos do estoque: "); 
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte); 

            Console.WriteLine("Dados do atualizados: " + p);
        }
    }
}
