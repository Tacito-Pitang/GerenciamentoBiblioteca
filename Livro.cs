using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoBiblioteca
{
    internal class Livro : ItemBiblioteca
    {

        public bool Disponivel { get; set; }

        public void EmprestarLivro()
        {
            if (Disponivel)
            {
                Disponivel = false;
                Console.WriteLine($"O livro '{Titulo}' foi emprestado.");
            }
            else
            {
                Console.WriteLine($"O livro '{Titulo}' não está disponível.");
            }
        }
        public void DevolverLivro()
        {
            if (Disponivel == false)
            {
                Disponivel = true;
                Console.WriteLine($"O livro '{Titulo}' foi devolvido.");
            }
            else
            {
                Console.WriteLine($"O livro '{Titulo}' já está disponível.");
            }
        }

    }

}

