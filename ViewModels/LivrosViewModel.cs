using System.Collections.ObjectModel;
using bibliotecaVirtual_com_MVVM_.Models;

namespace bibliotecaVirtual_com_MVVM_.ViewModels
{
    public class LivrosViewModel
    {
        public ObservableCollection<Livros> Livros { get; set; }

        public LivrosViewModel()
        {
            //livros previamente cadastrados
            Livros = new ObservableCollection<Livros>
            {
                new Livros
                {
                    Titulo = "Jogos Vorazes",
                    Autor = "Suzanne Collins",
                    ImagemUrl = "https://conteudo.imguol.com.br/c/entretenimento/0d/2018/04/02/jennifer-lawrence-em-cena-de-jogos-vorazes-2012-1522697409235_v2_900x506.jpg",
                    Status = "Incompleto",
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
    }
}
