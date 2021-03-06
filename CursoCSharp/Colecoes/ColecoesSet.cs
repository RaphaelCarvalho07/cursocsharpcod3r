/* 
Sets não são indexados e Set não aceita repetição
 */
using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    class ColecoesSet
    {
        public static void Executar()
        {
            var livro = new Produto("Game of Thrones", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto>
            {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Thrones", 99.9),
                new Produto("Poster", 10),
                new Produto("Poster", 10)
            };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            // carrinho.RemoveAt(3);
            
            foreach (var item in carrinho)
            {
                // Console.Write($"Índice do item {carrinho.IndexOf(item)},");
                Console.WriteLine($" Nome => {item.Nome}, Preço => {item.Preco}");
            }

            Console.WriteLine($"Antes de tentar adicionar o livro => {carrinho.Count}");
            carrinho.Add(livro);
            Console.WriteLine($"Depois de tentar adicionar o livro => {carrinho.Count}");
            // Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}