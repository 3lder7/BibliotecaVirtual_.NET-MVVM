using System.Collections.ObjectModel;
using bibliotecaVirtual_com_MVVM_.Models;

namespace bibliotecaVirtual_com_MVVM_.ViewModels
{
    public class MainPageViewModel
    {
        public ObservableCollection<Livros.Livro> Livros { get; set; }

        public MainPageViewModel()
        {
            //livros previamente cadastrados
            Livros = new ObservableCollection<Livros.Livro>
            {
                new Livros.Livro
                {
                    Titulo = "O Hobbit",
                    Autor = "J.R.R. Tolkien",
                    ImagemUrl = "https://linkparaimagem.com/ohobbit.jpg",
                    Status = "Lido",
                    qtdPagina = 310
                },
                new Livros.Livro
                {
                    Titulo = "Dom Casmurro",
                    Autor = "Machado de Assis",
                    ImagemUrl = "https://linkparaimagem.com/domcasmurro.jpg",
                    Status = "Em leitura",
                    qtdPagina = 256
                }
            };
        }
    }
}
