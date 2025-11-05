namespace bibliotecaVirtual_com_MVVM_.Views;
using System;
using bibliotecaVirtual_com_MVVM_.Models;
using bibliotecaVirtual_com_MVVM_.Services;
using Microsoft.Maui.Media;

public partial class CadastrarLivro : ContentPage
{
    private string? _imagemLocalPath;

    public CadastrarLivro()
    {
        InitializeComponent();
    }

    private async void OnPickImageClicked(object sender, EventArgs e)
    {
        try
        {
            // pede ao usuário para selecionar uma foto 
            FileResult photo = await MediaPicker.PickPhotoAsync();

            if (photo != null)
            {
                // copia a foto para o diretório local do app
                string localPath = Path.Combine(FileSystem.AppDataDirectory, photo.FileName);

                using (var stream = await photo.OpenReadAsync())
                using (var newStream = File.OpenWrite(localPath))
                {
                    await stream.CopyToAsync(newStream);
                }

                // guarda o caminho local
                _imagemLocalPath = localPath;

                // exibe a imagem
                Imagem.Source = ImageSource.FromFile(localPath);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao selecionar a foto: {ex.Message}");
            await DisplayAlert("Erro", "Não foi possível carregar a imagem.", "OK");
        }
    }

    private async void OnCadastrarClicked(object sender, EventArgs e)
    {
        try
        {
            string titulo = TituloEntry?.Text?.Trim() ?? string.Empty;
            string autor = AutorEntry?.Text?.Trim() ?? string.Empty;
            int paginas = 0;

            if (!int.TryParse(QtdPaginasEntry?.Text?.Trim(), out paginas))
            {
                paginas = 0;
            }

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor))
            {
                await DisplayAlert("Validação", "Preencha título e autor.", "OK");
                return;
            }

            var novoLivro = new Livros
            {
                Titulo = titulo,
                Autor = autor,
                ImagemUrl = _imagemLocalPath ?? string.Empty, //salva o caminho local
                Status = "Não lido",
                qtdPagina = paginas
            };

            LivroService.Instance.AdicionarLivro(novoLivro);

            await DisplayAlert("Sucesso", "Livro cadastrado com sucesso!", "OK");

            // limpar campos
            TituloEntry.Text = string.Empty;
            AutorEntry.Text = string.Empty;
            QtdPaginasEntry.Text = string.Empty;
            Imagem.Source = null;
            _imagemLocalPath = null;
        }
        catch (Exception ex)
        {
            await DisplayAlert("Erro", $"Ocorreu um erro ao cadastrar o livro: {ex.Message}", "OK");
        }
    }
}
