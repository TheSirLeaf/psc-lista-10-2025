namespace Models
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public int NumeroDePaginas { get; set; }
        public int PaginaAtual { get; set; }

        public Livro() { }

        public Livro(string titulo, string autor, string genero, int numeroDePaginas, int paginaAtual)
        {
            Titulo = titulo;
            Autor = autor;
            Genero = genero;
            NumeroDePaginas = numeroDePaginas;
            PaginaAtual = paginaAtual;
        }

        public void Abrir() { Console.WriteLine($"Abrindo '{Titulo}' na página {PaginaAtual}."); }
        public void Fechar() { Console.WriteLine($"Fechando '{Titulo}'."); }
        public void Folhear()
        {
            PaginaAtual = System.Math.Min(NumeroDePaginas, PaginaAtual + 5);
            Console.WriteLine($"Folheando... agora na página {PaginaAtual}.");
        }
        public void MarcarPagina() { Console.WriteLine($"Página {PaginaAtual} marcada em '{Titulo}'."); }
        public void Ler() { Console.WriteLine($"Lendo '{Titulo}', página {PaginaAtual}..."); }
    }
}
