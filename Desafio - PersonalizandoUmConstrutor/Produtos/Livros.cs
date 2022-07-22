using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio___PersonalizandoUmConstrutor.Produtos
{
    public class Livros
    {
        public string Isbn { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public int AnoPublicacao { get; set; }
        public string EstiloLiterario { get; set; }
        public int NumeroPaginas { get; set; }
        public string PaisPublicacao { get; set; }

        public Livros(string isbn, string nome)
        {
            Isbn = isbn;
            Nome = nome;
        }

        public void ExibirDadosProduto()
        {
            Console.WriteLine("Informações sobre o Livro:");
            Console.WriteLine();
            Console.WriteLine("ISBN: " + Isbn);
            Console.WriteLine("Titulo do Livro: " + Nome);
            Console.WriteLine("Autor: " + Autor);
            Console.WriteLine("Ano de Publicação: " + AnoPublicacao);
            Console.WriteLine("Estilo Literário: " + EstiloLiterario);
            Console.WriteLine("Nº de páginas: " + NumeroPaginas);
            Console.WriteLine("Pais de origem: " + PaisPublicacao);
            Console.WriteLine();
        }
    }
}

  