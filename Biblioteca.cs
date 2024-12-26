using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca
{
    internal class Biblioteca
    {
        // Lista de itens na biblioteca
        public List<ItemBiblioteca> Itens { get; set; } = new List<ItemBiblioteca>();

       
        public void AdicionarItem(ItemBiblioteca item)
        {
            Itens.Add(item);
            Console.WriteLine($"Item '{item.Titulo}' foi adicionado à biblioteca.");
        }

   
        public void ListarItens()
        {
            if (Itens.Count == 0)
            {
                Console.WriteLine("Não há itens na biblioteca.");
                return;
            }

            Console.WriteLine("\nItens da Biblioteca:");
            foreach (var item in Itens)
            {
                item.ExibirDetalhes();
                Console.WriteLine();
            }
        }

      
        public void BuscarPorTitulo(string titulo)
        {
            var resultados = Itens.Where(i => i.Titulo.Contains(titulo)).ToList();
            if (resultados.Count == 0)
            {
                Console.WriteLine($"Nenhum item encontrado com o título '{titulo}'.");
                return;
            }

            Console.WriteLine($"\nItens encontrados com o título '{titulo}':");
            foreach (var item in resultados)
            {
                item.ExibirDetalhes();
                Console.WriteLine();
            }
        }

      
        public void BuscarPorAutor(string autor)
        {
            var resultados = Itens.Where(i => i.Autor.Contains(autor)).ToList();
            if (resultados.Count == 0)
            {
                Console.WriteLine($"Nenhum item encontrado com o autor '{autor}'.");
                return;
            }

            Console.WriteLine($"\nItens encontrados do autor '{autor}':");
            foreach (var item in resultados)
            {
                item.ExibirDetalhes();
                Console.WriteLine();
            }
        }
    }
}
