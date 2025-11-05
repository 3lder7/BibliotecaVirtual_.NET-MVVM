using System.Collections.ObjectModel;
using bibliotecaVirtual_com_MVVM_.Models;
using bibliotecaVirtual_com_MVVM_.Services;

namespace bibliotecaVirtual_com_MVVM_.ViewModels
{
    public class LivrosViewModel
    {
        public ObservableCollection<Livros> Livros { get; set; }

        public LivrosViewModel()
        {
            Livros = LivroService.Instance.Livros;
        }
    }
}
