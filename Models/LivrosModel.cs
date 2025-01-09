using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliotecaVirtual_com_MVVM_.Models
{
    public class Livros
    {
        public class Livro
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public string ImagemUrl { get; set; }
            public string Status { get; set; }
            public int qtdPagina { get; set; }
        }

    }
}
