using System.Collections.ObjectModel;
using bibliotecaVirtual_com_MVVM_.Models;

namespace bibliotecaVirtual_com_MVVM_.Services
{
    public class LivroService
    {
        private static LivroService? instance;
        public static LivroService Instance => instance ??= new LivroService();

        public ObservableCollection<Livros> Livros { get; private set; }

        private LivroService()
        {
            Livros = new ObservableCollection<Livros>
            {
                //livros previamente cadastrados
                new Livros
                {
                    Titulo = "Jogos Vorazes",
                    Autor = "Suzanne Collins",
                    ImagemUrl = "https://conteudo.imguol.com.br/c/entretenimento/0d/2018/04/02/jennifer-lawrence-em-cena-de-jogos-vorazes-2012-1522697409235_v2_900x506.jpg",
                    Status = "Lendo",
                    qtdPagina = 400
                },
                new Livros
                {
                    Titulo = "Fahrenheit 451",
                    Autor = "Ray Bradbury",
                    ImagemUrl = "https://2.bp.blogspot.com/-wQpjqbuwVrU/Ww8NImQ4s8I/AAAAAAAANkg/EwKrwm4VjdgelWngLduneVsp_93vcrekgCEwYBhgL/s1600/fahrenheit451-768x415.jpg",
                    Status = "Finalizado",
                    qtdPagina = 215
                }
            };
        }

        public void AdicionarLivro(Livros livro)
        {
            Livros.Add(livro);
        }
    }
}
