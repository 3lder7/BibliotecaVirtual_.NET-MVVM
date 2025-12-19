namespace bibliotecaVirtual_com_MVVM_.Views;
using bibliotecaVirtual_com_MVVM_.Models;
using bibliotecaVirtual_com_MVVM_.Services;
public partial class EditarLivro : ContentPage
{
    private Livros _livroEditando;
    private string? _imagemLocalPath;
    public EditarLivro(Livros livro)
	{
        InitializeComponent();
        _livroEditando = livro;

        // preencher campos
        TituloEntry.Text = livro.Titulo;
        AutorEntry.Text = livro.Autor;
        QtdPaginasEntry.Text = livro.qtdPagina.ToString();

        if (!string.IsNullOrEmpty(livro.ImagemUrl))
            Imagem.Source = ImageSource.FromFile(livro.ImagemUrl);

        _imagemLocalPath = livro.ImagemUrl;
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

    private async void OnSalvarClicked(object sender, EventArgs e)
    {
        string titulo = TituloEntry.Text?.Trim() ?? string.Empty;
        string autor = AutorEntry.Text?.Trim() ?? string.Empty;

        if (!int.TryParse(QtdPaginasEntry.Text, out int paginas))
            paginas = 0;

        if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor))
        {
            await DisplayAlert("Validação", "Preencha título e autor.", "OK");
            return;
        }

        // atualiza o msm objeto
        _livroEditando.Titulo = titulo;
        _livroEditando.Autor = autor;
        _livroEditando.qtdPagina = paginas;
        _livroEditando.ImagemUrl = _imagemLocalPath ?? _livroEditando.ImagemUrl;

        await DisplayAlert("Sucesso", "Livro atualizado com sucesso!", "OK");

        await Navigation.PopAsync();
    }
}