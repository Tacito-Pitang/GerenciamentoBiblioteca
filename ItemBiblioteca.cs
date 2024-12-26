using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca
{
    internal class ItemBiblioteca
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public string Autor {  get; set; }

        public int AnoPublicacao { get; set; }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Ano de Publicação: {AnoPublicacao}");
        }
    }
}
