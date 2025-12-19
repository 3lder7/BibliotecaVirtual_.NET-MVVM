using System.ComponentModel;

namespace bibliotecaVirtual_com_MVVM_.Models
{
    public class Livros : INotifyPropertyChanged
    {
        private string _titulo;
        private string _autor;
        private string _imagemUrl;
        private string _status;
        private int _qtdPagina;

        public string Titulo
        {
            get => _titulo;
            set { _titulo = value; OnPropertyChanged(nameof(Titulo)); }
        }

        public string Autor
        {
            get => _autor;
            set { _autor = value; OnPropertyChanged(nameof(Autor)); }
        }

        public string ImagemUrl
        {
            get => _imagemUrl;
            set { _imagemUrl = value; OnPropertyChanged(nameof(ImagemUrl)); }
        }

        public string Status
        {
            get => _status;
            set { _status = value; OnPropertyChanged(nameof(Status)); }
        }

        public int qtdPagina
        {
            get => _qtdPagina;
            set { _qtdPagina = value; OnPropertyChanged(nameof(qtdPagina)); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}